namespace BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen
{
    using Newtonsoft.Json;

    /// <summary>
    /// Represents settings around Definition templates.
    /// </summary>
    public class CodeGenerationDefinitionTemplateSettings
    {
        public CodeGenerationDefinitionTemplateSettings()
        {
            //Set Defaults;
            CommandTemplate = new CodeGenerationTemplateSettings {
                TemplatePath = "command.mustache",
                OutputPath = "{{domainName}}\\{{className}}Command.cs",
                RemoveNewLines = false
            };

            EventTemplate = new CodeGenerationTemplateSettings
            {
                TemplatePath = "event.mustache",
                OutputPath = "{{domainName}}\\{{className}}Event.cs",
                RemoveNewLines = false
            };

            TypeObjectTemplate = new CodeGenerationTemplateSettings
            {
                TemplatePath = "type-object.mustache",
                OutputPath = "{{domainName}}\\{{className}}.cs",
                RemoveNewLines = false
            };

            TypeEnumTemplate = new CodeGenerationTemplateSettings
            {
                TemplatePath = "type-enum.mustache",
                OutputPath = "{{domainName}}\\{{className}}.cs",
                RemoveNewLines = false
            };
        }

        [JsonProperty("commandTemplate")]
        public CodeGenerationTemplateSettings CommandTemplate
        {
            get;
            set;
        }

        [JsonProperty("eventTemplate")]
        public CodeGenerationTemplateSettings EventTemplate
        {
            get;
            set;
        }

        [JsonProperty("typeObjectTemplate")]
        public CodeGenerationTemplateSettings TypeObjectTemplate
        {
            get;
            set;
        }

        [JsonProperty("typeEnumTemplate")]
        public CodeGenerationTemplateSettings TypeEnumTemplate
        {
            get;
            set;
        }

    }
}
