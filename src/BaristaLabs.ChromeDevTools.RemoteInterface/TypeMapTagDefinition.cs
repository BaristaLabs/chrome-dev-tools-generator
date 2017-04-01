namespace BaristaLabs.ChromeDevTools.RemoteInterface
{
    using BaristaLabs.ChromeDevTools.RemoteInterface.DebuggerProtocol;
    using Mustache;
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class TypeMapTagDefinition : ContentTagDefinition
    {
        public TypeMapTagDefinition()
            : base("typemap")
        {
        }

        public override IEnumerable<NestedContext> GetChildContext(TextWriter writer, Scope keyScope, Dictionary<string, object> arguments, Scope contextScope)
        {
            NestedContext context = new NestedContext()
            {
                KeyScope = keyScope,
                Writer = new StringWriter(),
                WriterNeedsConsidated = true,
            };
            yield return context;
        }

        protected override IEnumerable<TagParameter> GetParameters()
        {
            return new TagParameter[] {
                new TagParameter("DomainDefinition") { IsRequired = true },
                new TagParameter("TypeDefinition") { IsRequired = true },
                new TagParameter("KnownTypes") { IsRequired = false }
            };
        }

        public override IEnumerable<TagParameter> GetChildContextParameters()
        {
            return new TagParameter[] { new TagParameter("collection") };
        }

        public override string ConsolidateWriter(TextWriter writer, Dictionary<string, object> arguments)
        {
            var type = writer.ToString();

            var domainDefinition = arguments["DomainDefinition"] as DomainDefinition;
            if (domainDefinition == null)
                throw new InvalidOperationException("Expected DomainDefinition argument to be non-null.");

            var typeDefinition = arguments["TypeDefinition"] as TypeDefinition;
            if (typeDefinition == null)
                throw new InvalidOperationException("Expected TypeDefinition argument to be non-null.");

            var knownTypes = arguments["KnownTypes"] as IDictionary<string, TypeInfo>;
            
            return GetTypeMappingForType(typeDefinition, domainDefinition, knownTypes);
        }

        private string GetTypeMappingForType(TypeDefinition typeDefinition, DomainDefinition domainDefinition, IDictionary<string, TypeInfo> knownTypes, bool isArray = false)
        {
            var type = typeDefinition.Type;

            if (String.IsNullOrWhiteSpace(type))
                type = typeDefinition.TypeReference;

            if (type.Contains(".") && knownTypes.ContainsKey(type))
            {
                var typeInfo = knownTypes[type];
                if (typeInfo.IsPrimitive)
                    return typeInfo.TypeName;
                return $"{typeInfo.Namespace}.{typeInfo.TypeName}";
            }

            var fullyQualifiedTypeName = $"{domainDefinition.Name}.{type}";

            if (knownTypes.ContainsKey(fullyQualifiedTypeName))
                return knownTypes[fullyQualifiedTypeName].TypeName;

            switch (type)
            {
                case "number":
                    return "double";
                case "integer":
                    return "long";
                case "boolean":
                    return "bool";
                case "string":
                    return "string";
                case "object":
                case "any":
                    return "object";
                case "array":
                    return GetTypeMappingForType(typeDefinition.Items, domainDefinition, knownTypes, true);
                default:
                    throw new InvalidOperationException($"Unmapped data type: {type}");
            }
        }
    }
}
