namespace BaristaLabs.ChromeDevTools.RemoteInterface
{
    /// <summary>
    /// Settings to be passed to a ICodeGenerator
    /// </summary>
    public sealed class CodeGenerationSettings
    {
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

        
    }
}
