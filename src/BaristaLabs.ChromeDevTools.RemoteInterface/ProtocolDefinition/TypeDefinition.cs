namespace BaristaLabs.ChromeDevTools.RemoteInterface.ProtocolDefinition
{
    using BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen;
    using Humanizer;
    using Mustache;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public sealed class TypeDefinition : ProtocolDefinitionItem, ICodeGenerator
    {
        public TypeDefinition()
        {
            Enum = new HashSet<string>();
            Properties = new Collection<TypeDefinition>();
        }

        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "type")]
        public string Type
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "enum")]
        public ICollection<string> Enum
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "properties")]
        public ICollection<TypeDefinition> Properties
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "items")]
        public TypeDefinition Items
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "minItems")]
        public int MinItems
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "maxItems")]
        public int MaxItems
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "$ref")]
        public string TypeReference
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "optional")]
        public bool Optional
        {
            get;
            set;
        }

        public IDictionary<string, string> GenerateCode(CodeGenerationSettings settings, dynamic options)
        {
            var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            var knownTypes = options.knownTypes as IDictionary<string, TypeInfo>;
            if (knownTypes == null)
                throw new InvalidOperationException("Expected knowntypes to be specified in options");

            var domain = options.domain as DomainDefinition;
            if (domain == null)
                throw new InvalidOperationException("Expected domain to be specified in options");

            var typeInfo = knownTypes[$"{domain.Name}.{Id}"];
            if (typeInfo.IsPrimitive)
                return result;

            var className = Id.Dehumanize();
            Generator typeGenerator;

            //Base the code generation template on the specified type definition type.
            switch (Type)
            {
                case "object":
                    typeGenerator = TemplatesManager.GetGeneratorForTemplate($"{settings.TemplatesPath}\\type-object.mustache");
                    break;
                case "string":
                    typeGenerator = TemplatesManager.GetGeneratorForTemplate($"{settings.TemplatesPath}\\type-enum.mustache");
                    break;
                default:
                    throw new InvalidOperationException($"Unsupported Type Definition Type: {Type}");
            }

            var codeResult = typeGenerator.Render(new
            {
                type = this,
                className = className,
                domain = domain,
                knownTypes = options.knownTypes, //Setting this to the KnownTypes dictionary results in an exception in mustache -- constructor not found...
                rootNamespace = settings.RootNamespace,
            });

            result.Add($"{settings.OutputPath}\\{options.domain.Name}\\{className}.cs", codeResult);

            return result;
        }

        public override string ToString()
        {
            if (!String.IsNullOrWhiteSpace(Id))
                return Id;

            if (!String.IsNullOrWhiteSpace(Name))
                return Name;

            return $"Ref: {TypeReference}";
        }
    }
}
