﻿namespace BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen
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

        public override IDictionary<string, string> GenerateCode(ProtocolDefinition protocolDefinition, CodeGeneratorContext context)
        {
            if (String.IsNullOrWhiteSpace(Settings.TemplatesPath))
            {
                Settings.TemplatesPath = Path.GetDirectoryName(Settings.TemplatesPath);
            }

            ICollection<DomainDefinition> domains;
            if (Settings.IncludeDeprecatedDomains)
                domains = protocolDefinition.Domains;
            else
                domains = protocolDefinition.Domains
                    .Where(d => d.Deprecated == false)
                    .ToList();

            //Get commandinfos as an array.
            ICollection<CommandInfo> commands = new List<CommandInfo>();

            foreach (var domain in domains)
            {
                foreach (var command in domain.Commands)
                {
                    commands.Add(new CommandInfo
                    {
                        CommandName = $"{domain.Name}.{command.Name}",
                        FullTypeName = $"{domain.Name.Dehumanize()}.{command.Name.Dehumanize()}Command",
                        FullResponseTypeName = $"{domain.Name.Dehumanize()}.{command.Name.Dehumanize()}CommandResponse"
                    });
                }
            }

            //Get eventinfos as an array
            ICollection<EventInfo> events = new List<EventInfo>();

            foreach(var domain in domains)
            {
                foreach(var @event in domain.Events)
                {
                    events.Add(new EventInfo
                    {
                        EventName = $"{domain.Name}.{@event.Name}",
                        FullTypeName = $"{domain.Name.Dehumanize()}.{@event.Name.Dehumanize()}Event"
                    });
                }
            }

            //Get typeinfos as a dictionary.
            var types = GetTypesInDomain(domains);

            //Create an object that contains information that include templates can use.
            var includeData = new {
                chromeVersion = protocolDefinition.ChromeVersion,
                runtimeVersion = Settings.RuntimeVersion,
                rootNamespace = Settings.RootNamespace,
                domains = domains,
                commands = commands,
                events = events,
                types = types.Select(kvp => kvp.Value).ToList()
            };

            var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            //Generate include files from templates.
            foreach (var include in Settings.Include)
            {
                var includeCodeGenerator = TemplatesManager.GetGeneratorForTemplate(include);
                var includeCodeResult = includeCodeGenerator(includeData);
                result.Add(include.OutputPath, includeCodeResult);
            }

            //Generate code for each domain, type, command, event from their respective templates.
            GenerateCode(domains, types)
                .ToList()
                .ForEach(x => result.Add(x.Key, x.Value));

            return result;
        }

        private Dictionary<string, TypeInfo> GetTypesInDomain(ICollection<DomainDefinition> domains)
        {
            var knownTypes = new Dictionary<string, TypeInfo>(StringComparer.OrdinalIgnoreCase);

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
                                IsPrimitive = false,
                                TypeName = type.Id.Dehumanize(),
                            };
                            break;
                        case "string":
                            if (type.Enum != null && type.Enum.Count() > 0)
                                typeInfo = new TypeInfo
                                {
                                    ByRef = true,
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
                            if ((type.Items == null || String.IsNullOrWhiteSpace(type.Items.Type))
                                && type.Items.TypeReference != "StringIndex"
                                && type.Items.TypeReference != "FilterEntry")
                            {
                                throw new NotImplementedException($"Did not expect array type {type.ToString()} of top-level domain {domain.ToString()} to specify a TypeReference");
                            }

                            string itemType;
                            switch (type.Items.Type)
                            {
                                case "string":
                                    itemType = "string";
                                    break;
                                case "number":
                                    itemType = "double";
                                    break;
                                case null:
                                    if (String.IsNullOrWhiteSpace(type.Items.TypeReference))
                                        throw new NotImplementedException($"Did not expect a top-level domain array type to have a null type and a null or whitespace type reference.");

                                    switch (type.Items.TypeReference)
                                    {
                                        case "StringIndex":
                                            itemType = "string";
                                            break;
                                        case "FilterEntry":
                                            itemType = "FilterEntry";
                                            break;
                                        default:
                                            throw new NotImplementedException($"Did not expect a top-level domain array type to specify a type reference of {type.Items.TypeReference}");
                                    }
                                    break;
                                default:
                                    throw new NotImplementedException($"Did not expect a top-level domain array type to specify items of type {type.Items.Type}");
                            }
                            typeInfo = new TypeInfo
                            {
                                IsPrimitive = true,
                                TypeName = $"{itemType}[]"
                            };
                            break;
                        case "number":
                            typeInfo = new TypeInfo
                            {
                                ByRef = true,
                                IsPrimitive = true,
                                TypeName = "double"
                            };
                            break;
                        case "integer":
                            typeInfo = new TypeInfo
                            {
                                ByRef = true,
                                IsPrimitive = true,
                                TypeName = "long"
                            };
                            break;
                        default:
                            throw new InvalidOperationException($"Unknown Type Definition Type: {type.Id}");
                    }

                    typeInfo.Namespace = domain.Name.Dehumanize();
                    typeInfo.SourcePath = $"{domain.Name}.{type.Id}";
                    knownTypes.Add($"{domain.Name}.{type.Id}", typeInfo);
                }
            }

            return knownTypes;
        }

        private IDictionary<string, string> GenerateCode(ICollection<DomainDefinition> domains, Dictionary<string, TypeInfo> knownTypes)
        {
            var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            var domainGenerator = ServiceProvider.GetRequiredService<ICodeGenerator<DomainDefinition>>();

            //Generate types/events/commands for all domains.
            foreach (var domain in domains)
            {
                domainGenerator.GenerateCode(domain, new CodeGeneratorContext { Domain = domain, KnownTypes = knownTypes })
                    .ToList()
                    .ForEach(x => result.Add(x.Key, x.Value));
            }

            return result;
        }
    }
}
