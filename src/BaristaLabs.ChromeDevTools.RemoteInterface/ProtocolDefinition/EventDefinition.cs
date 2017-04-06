namespace BaristaLabs.ChromeDevTools.RemoteInterface.ProtocolDefinition
{
    using BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public sealed class EventDefinition : ProtocolDefinitionItem, ICodeGenerator
    {
        public EventDefinition()
        {
            Parameters = new Collection<TypeDefinition>();
        }

        [JsonProperty(PropertyName = "parameters")]
        public ICollection<TypeDefinition> Parameters
        {
            get;
            set;
        }

        public IDictionary<string, string> GenerateCode(CodeGenerationSettings settings, dynamic options)
        {
            var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            var eventGenerator = TemplatesManager.GetGeneratorForTemplate($"{settings.TemplatesPath}\\event.mustache");
            return result;
        }
    }
}
