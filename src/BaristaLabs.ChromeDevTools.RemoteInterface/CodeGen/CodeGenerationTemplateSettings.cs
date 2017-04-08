namespace BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines settings around templates
    /// </summary>
    public class CodeGenerationTemplateSettings
    {
        [JsonProperty("templatePath")]
        public string TemplatePath
        {
            get;
            set;
        }

        [JsonProperty("outputPath")]
        public string OutputPath
        {
            get;
            set;
        }

        [JsonProperty("removeNewLines")]
        public bool RemoveNewLines
        {
            get;
            set;
        }
    }
}
