namespace BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Settings to be passed to a ICodeGenerator
    /// </summary>
    public sealed class CodeGenerationSettings
    {
        public CodeGenerationSettings()
        {
            //Set defaults
            Include = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            IncludeDeprecatedDomains = true;
            RootNamespace = "BaristaLabs.ChromeDevTools";
            Templates = new CodeGenerationTemplateSettings();
            TemplatesPath = "Templates";
            UsingStatements = new List<string>()
            {
                "System"
            };
        }

        /// <summary>
        /// Collection of templates that will be parsed and output in the target folder.
        /// </summary>
        [JsonProperty("include")]
        public IDictionary<string, string> Include
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates whether or not domains marked as depreciated will be generated. (Default: true)
        /// </summary>
        [JsonProperty("includeDeprecatedDomains")]
        public bool IncludeDeprecatedDomains
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the absolute path to the folder where code files should be produced.
        /// </summary>
        [JsonProperty("outputPath")]
        public string OutputPath
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the root namespace of generated classes.
        /// </summary>
        [JsonProperty("rootNamespace")]
        public string RootNamespace
        {
            get;
            set;
        }

        [JsonProperty("templates")]
        public CodeGenerationTemplateSettings Templates
        {
            get;
            set;
        }

        [JsonProperty("templatesPath")]
        public string TemplatesPath
        {
            get;
            set;
        }

        /// <summary>
        /// The using statements that will be included on each generated file.
        /// </summary>
        [JsonProperty("usingStatements")]
        public ICollection<string> UsingStatements
        {
            get;
            set;
        }
    }
}
