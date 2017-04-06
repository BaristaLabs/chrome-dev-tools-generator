namespace BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen
{
    using BaristaLabs.ChromeDevTools.RemoteInterface.ProtocolDefinition;
    using Humanizer;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// Represents an object that generates a protocol definition.
    /// </summary>
    public sealed class ProtocolGenerator : CodeGeneratorBase<ProtocolDefinition>
    {
        public ProtocolGenerator(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        public override IDictionary<string, string> GenerateCode(ProtocolDefinition protocolDefinition, dynamic options)
        {
            if (String.IsNullOrWhiteSpace(Settings.TemplatesPath))
            {
                Settings.TemplatesPath = Path.GetDirectoryName(Settings.TemplatesPath);
            }

            var includeData = new {
                rootNamespace = Settings.RootNamespace
            };

            var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            foreach (var include in Settings.Include)
            {
                var includeCodeGenerator = TemplatesManager.GetGeneratorForTemplate(include.Key);
                var includeCodeResult = includeCodeGenerator.Render(includeData);
                result.Add($"{Settings.OutputPath}\\{include.Value}", includeCodeResult);
            }

            GenerateCode(protocolDefinition)
                .ToList()
                .ForEach(x => result.Add(x.Key, x.Value));

            return result;
        }


        private IDictionary<string, string> GenerateCode(ProtocolDefinition protocolDefinition)
        {
            var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            ICollection<DomainDefinition> domains;
            if (Settings.IncludeDeprecatedDomains)
                domains = protocolDefinition.Domains;
            else
                domains = protocolDefinition.Domains
                    .Where(d => d.Deprecated == false)
                    .ToList();

            IDictionary<string, TypeInfo> knownTypes = new Dictionary<string, TypeInfo>(StringComparer.OrdinalIgnoreCase);

            //First pass - get all top-level types.
            foreach (var domain in domains)
            {
                foreach (var type in domain.Types)
                {
                    TypeInfo typeInfo;
                    switch (type.Type)
                    {
                        case "object":
                            typeInfo = new TypeInfo
                            {
                                Namespace = $"{Settings.RootNamespace}.{domain.Name.Dehumanize()}",
                                IsPrimitive = false,
                                TypeName = type.Id.Dehumanize(),
                            };
                            break;
                        case "string":
                            if (type.Enum != null && type.Enum.Count() > 0)
                                typeInfo = new TypeInfo
                                {
                                    Namespace = $"{Settings.RootNamespace}.{domain.Name.Dehumanize()}",
                                    IsPrimitive = false,
                                    TypeName = type.Id.Dehumanize(),
                                };
                            else
                                typeInfo = new TypeInfo
                                {
                                    IsPrimitive = true,
                                    TypeName = "string"
                                };
                            break;
                        case "array":
                            if (type.Items == null || String.IsNullOrWhiteSpace(type.Items.Type))
                                throw new NotImplementedException("Did not expect a top-level domain array type to specify a TypeReference");

                            typeInfo = new TypeInfo
                            {
                                IsPrimitive = true,
                                TypeName = $"{type.Items.Type}[]"
                            };
                            break;
                        case "number":
                            typeInfo = new TypeInfo
                            {
                                IsPrimitive = true,
                                TypeName = "double"
                            };
                            break;
                        case "integer":
                            typeInfo = new TypeInfo
                            {
                                IsPrimitive = true,
                                TypeName = "long"
                            };
                            break;
                        default:
                            throw new InvalidOperationException($"Unknown Type Definition Type: {type.Id}");
                    }

                    knownTypes.Add($"{domain.Name}.{type.Id}", typeInfo);
                }
            }

            var domainGenerator = ServiceProvider.GetRequiredService<ICodeGenerator<DomainDefinition>>();

            //Generate types/events/commands for all domains.
            foreach (var domain in domains)
            {
                domainGenerator.GenerateCode(domain, new { knownTypes = knownTypes })
                    .ToList()
                    .ForEach(x => result.Add(x.Key, x.Value));
            }

            return result;
        }
    }
}
