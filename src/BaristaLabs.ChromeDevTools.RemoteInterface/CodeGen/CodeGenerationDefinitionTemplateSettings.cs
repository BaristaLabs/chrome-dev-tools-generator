namespace BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen
{
    using Newtonsoft.Json;

    public class CodeGenerationDefinitionTemplateSettings
    {
        public CodeGenerationDefinitionTemplateSettings()
        {
            //Set Defaults;
            CommandTemplate = new CodeGenerationTemplateSettings {
                TemplatePath = "command.mustache",
                OutputPath = "",
                RemoveNewLines = false
            };

            EventTemplate = new CodeGenerationTemplateSettings
            {
                TemplatePath = "event.mustache",
                OutputPath = "",
                RemoveNewLines = false
            };

            TypeObjectTemplate = new CodeGenerationTemplateSettings
            {
                TemplatePath = "type-object.mustache",
                OutputPath = "",
                RemoveNewLines = false
            };

            TypeEnumTemplate = new CodeGenerationTemplateSettings
            {
                TemplatePath = "type-enum.mustache",
                OutputPath = "",
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
