namespace BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen
{
    using BaristaLabs.ChromeDevTools.RemoteInterface.ProtocolDefinition;
    using Humanizer;
    using Mustache;
    using System;
    using System.Collections.Generic;
    using System.IO;

    public sealed class TypeGenerator : CodeGeneratorBase<TypeDefinition>
    {
        public TypeGenerator(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        public override IDictionary<string, string> GenerateCode(TypeDefinition typeDefinition, dynamic options)
        {
            var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            var knownTypes = options.knownTypes as IDictionary<string, TypeInfo>;
            if (knownTypes == null)
                throw new InvalidOperationException("Expected knowntypes to be specified in options");

            var domain = options.domain as DomainDefinition;
            if (domain == null)
                throw new InvalidOperationException("Expected domain to be specified in options");

            var typeInfo = knownTypes[$"{domain.Name}.{typeDefinition.Id}"];
            if (typeInfo.IsPrimitive)
                return result;

            var className = typeDefinition.Id.Dehumanize();
            Generator typeGenerator;

            //Base the code generation template on the specified type definition type.
            switch (typeDefinition.Type)
            {
                case "object":
                    typeGenerator = TemplatesManager.GetGeneratorForTemplate(Settings.DefinitionTemplates.TypeObjectTemplate);
                    break;
                case "string":
                    typeGenerator = TemplatesManager.GetGeneratorForTemplate(Settings.DefinitionTemplates.TypeEnumTemplate);
                    break;
                default:
                    throw new InvalidOperationException($"Unsupported Type Definition Type: {typeDefinition.Type}");
            }

            var codeResult = typeGenerator.Render(new
            {
                type = typeDefinition,
                className = className,
                domain = domain,
                knownTypes = options.knownTypes, //Setting this to the KnownTypes dictionary results in an exception in mustache -- constructor not found...
                rootNamespace = Settings.RootNamespace,
            });

            result.Add(Path.Combine(options.domain.Name, $"{className}.cs"), codeResult);

            return result;
        }
    }
}
