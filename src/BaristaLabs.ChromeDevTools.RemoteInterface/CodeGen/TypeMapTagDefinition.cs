namespace BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen
{
    using BaristaLabs.ChromeDevTools.RemoteInterface.ProtocolDefinition;
    using Mustache;
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// Represents a Mustache-Sharp extension that maps a type name to a previously located type.
    /// </summary>
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
                new TagParameter("TypeDefinition") { IsRequired = true },
                new TagParameter("Context") { IsRequired = true }
            };
        }

        public override IEnumerable<TagParameter> GetChildContextParameters()
        {
            return new TagParameter[] { new TagParameter("collection") };
        }

        public override string ConsolidateWriter(TextWriter writer, Dictionary<string, object> arguments)
        {
            var type = writer.ToString();
            var typeDefinition = arguments["TypeDefinition"] as TypeDefinition;
            if (typeDefinition == null)
                throw new InvalidOperationException("Expected TypeDefinition argument to be non-null.");

            var context = arguments["Context"] as CodeGeneratorContext;
            if (context == null)
                throw new InvalidOperationException("Expected context argument to be non-null.");

            return GetTypeMappingForType(typeDefinition, context.Domain, context.KnownTypes);
        }

        private string GetTypeMappingForType(TypeDefinition typeDefinition, DomainDefinition domainDefinition, IDictionary<string, TypeInfo> knownTypes, bool isArray = false)
        {
            var type = typeDefinition.Type;

            if (String.IsNullOrWhiteSpace(type))
                type = typeDefinition.TypeReference;

            string mappedType = null;
            if (type.Contains(".") && knownTypes.ContainsKey(type))
            {
                var typeInfo = knownTypes[type];
                if (typeInfo.IsPrimitive)
                    return typeInfo.TypeName;
                mappedType = $"{typeInfo.Namespace}.{typeInfo.TypeName}";
            }

            if (mappedType == null)
            {
                var fullyQualifiedTypeName = $"{domainDefinition.Name}.{type}";

                if (knownTypes.ContainsKey(fullyQualifiedTypeName))
                    mappedType = knownTypes[fullyQualifiedTypeName].TypeName;
            }

            
            if (mappedType == null)
            {
                switch (type)
                {
                    case "number":
                        mappedType = "double";
                        break;
                    case "integer":
                        mappedType = "long";
                        break;
                    case "boolean":
                        mappedType = "bool";
                        break;
                    case "string":
                        mappedType = "string";
                        break;
                    case "object":
                    case "any":
                        mappedType = "object";
                        break;
                    case "array":
                        mappedType = GetTypeMappingForType(typeDefinition.Items, domainDefinition, knownTypes, true);
                        break;
                    default:
                        throw new InvalidOperationException($"Unmapped data type: {type}");
                }
            }

            return mappedType + (isArray ? "[]" : String.Empty);
        }
    }
}
