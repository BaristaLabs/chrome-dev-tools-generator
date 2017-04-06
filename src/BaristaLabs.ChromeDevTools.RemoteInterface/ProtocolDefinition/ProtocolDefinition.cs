namespace BaristaLabs.ChromeDevTools.RemoteInterface.ProtocolDefinition
{
    using BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen;
    using Humanizer;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    public sealed class ProtocolDefinition : ICodeGenerator
    {
        public ProtocolDefinition()
        {
            Domains = new Collection<DomainDefinition>();
        }

        [JsonProperty(PropertyName = "version", Required = Required.Always)]
        public Version Version
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "domains", Required = Required.Always)]
        public ICollection<DomainDefinition> Domains
        {
            get;
            set;
        }

        public IDictionary<string, string> GenerateCode(CodeGenerationSettings settings, dynamic options)
        {
            var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            ICollection<DomainDefinition> domains;
            if (settings.IncludeDeprecatedDomains)
                domains = Domains;
            else
                domains = Domains
                    .Where(d => d.Deprecated == false)
                    .ToList();

            IDictionary<string, TypeInfo> knownTypes = new Dictionary<string, TypeInfo>(StringComparer.OrdinalIgnoreCase);

            //First pass - get all top-level types.
            foreach (var domain in domains)
            {
                foreach (var type in domain.Types)
                {
                    TypeInfo typeInfo;
                    switch(type.Type)
                    {
                        case "object":
                            typeInfo = new TypeInfo
                            {
                                Namespace = $"{settings.RootNamespace}.{domain.Name.Dehumanize()}",
                                IsPrimitive = false,
                                TypeName = type.Id.Dehumanize(),
                            };
                            break;
                        case "string":
                            if (type.Enum != null && type.Enum.Count() > 0)
                                typeInfo = new TypeInfo
                                {
                                    Namespace = $"{settings.RootNamespace}.{domain.Name.Dehumanize()}",
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

            //Generate types/events/commands for all domains.
            foreach (var domain in domains)
            {
                domain.GenerateCode(settings, new { knownTypes = knownTypes })
                    .ToList()
                    .ForEach(x => result.Add(x.Key, x.Value));
            }

            return result;
        }
    }
}
