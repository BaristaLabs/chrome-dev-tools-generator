namespace BaristaLabs.ChromeDevTools.RemoteInterface.ProtocolDefinition
{
    using BaristaLabs.ChromeDevTools.RemoteInterface.Generator;
    using Humanizer;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public sealed class CommandDefinition : ProtocolDefinitionItem, ICodeGenerator
    {
        public CommandDefinition()
        {
            Handlers = new HashSet<string>();

            Parameters = new Collection<TypeDefinition>();
            Returns = new Collection<TypeDefinition>();
        }

        [JsonProperty(PropertyName = "handlers")]
        public ICollection<string> Handlers
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "parameters")]
        public ICollection<TypeDefinition> Parameters
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "returns")]
        public ICollection<TypeDefinition> Returns
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "redirect")]
        public string Redirect
        {
            get;
            set;
        }

        public IDictionary<string, string> GenerateCode(CodeGenerationSettings settings, dynamic options)
        {
            var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            var commandGenerator = TemplatesManager.GetGeneratorForTemplate($"{settings.TemplatesPath}\\command.mustache");

            var className = Name.Dehumanize();
            string codeResult = commandGenerator.Render(new
            {
                command = this,
                className = className,
                domain = options.domain,
                knownTypes = options.knownTypes,
                rootNamespace = settings.RootNamespace,
            });

            result.Add($"{settings.OutputPath}\\{options.domain.Name}\\{className}Command.cs", codeResult);
            return result;
        }
    }
}
