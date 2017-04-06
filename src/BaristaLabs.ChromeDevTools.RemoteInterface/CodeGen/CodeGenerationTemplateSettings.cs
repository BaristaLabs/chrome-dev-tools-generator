namespace BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen
{
    using Newtonsoft.Json;

    public class CodeGenerationTemplateSettings
    {
        public CodeGenerationTemplateSettings()
        {
            //Set Defaults;
            CommandTemplate = "command.mustache";
            EventTemplate = "event.mustache";
            TypeObjectTemplate = "type-object.mustache";
            TypeEnumTemplate = "type-enum.mustache";
        }

        [JsonProperty("commandTemplate")]
        public string CommandTemplate
        {
            get;
            set;
        }

        [JsonProperty("eventTemplate")]
        public string EventTemplate
        {
            get;
            set;
        }

        [JsonProperty("typeObjectTemplate")]
        public string TypeObjectTemplate
        {
            get;
            set;
        }

        [JsonProperty("typeEnumTemplate")]
        public string TypeEnumTemplate
        {
            get;
            set;
        }

    }
}
