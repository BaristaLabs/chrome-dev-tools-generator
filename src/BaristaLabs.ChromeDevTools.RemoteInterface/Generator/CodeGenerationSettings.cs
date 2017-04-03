namespace BaristaLabs.ChromeDevTools.RemoteInterface.Generator
{
    using System.Collections.Generic;

    /// <summary>
    /// Settings to be passed to a ICodeGenerator
    /// </summary>
    public sealed class CodeGenerationSettings
    {
        public CodeGenerationSettings()
        {
            IncludeDeprecatedDomains = true;
            UsingStatements = new List<string>()
            {
                "System"
            };
        }

        /// <summary>
        /// Gets or sets the absolute path to the folder where code files should be produced.
        /// </summary>
        public string OutputPath
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the root namespace of generated classes.
        /// </summary>
        public string RootNamespace
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the absolute path to the folder containing the code generation templates.
        /// </summary>
        public string TemplatesPath
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates whether or not domains marked as depreciated will be generated. (Default: true)
        /// </summary>
        public bool IncludeDeprecatedDomains
        {
            get;
            set;
        }

        /// <summary>
        /// The using statements that will be included on each generated file.
        /// </summary>
        public ICollection<string> UsingStatements
        {
            get;
            set;
        }
    }
}
