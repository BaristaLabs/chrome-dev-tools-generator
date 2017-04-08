namespace BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen
{
    using Mustache;
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// Represents a class that manages templates and their associated generators.
    /// </summary>
    public sealed class TemplatesManager
    {
        private readonly IDictionary<string, Generator> m_templateGenerators = new Dictionary<string, Generator>(StringComparer.OrdinalIgnoreCase);
        private readonly CodeGenerationSettings m_settings;

        /// <summary>
        /// Gets the code generation settings associated with the protocol generator
        /// </summary>
        public CodeGenerationSettings Settings
        {
            get { return m_settings; }
        }

        public TemplatesManager(CodeGenerationSettings settings)
        {
            m_settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        /// <summary>
        /// Returns a generator singleton for the specified template path.
        /// </summary>
        /// <param name="templatePath"></param>
        /// <returns></returns>
        public Generator GetGeneratorForTemplate(CodeGenerationTemplateSettings templateSettings)
        {
            var templatePath = templateSettings.TemplatePath;
            if (m_templateGenerators.ContainsKey(templatePath))
                return m_templateGenerators[templatePath];

            var targetTemplate = templatePath;
            if (!Path.IsPathRooted(targetTemplate))
                targetTemplate = Path.Combine(Settings.TemplatesPath, targetTemplate);

            if (!File.Exists(targetTemplate))
                throw new FileNotFoundException($"Unable to locate a template at {targetTemplate} - please ensure that a template file exists at this location.");

            var templateContents = File.ReadAllText(targetTemplate);

            var compiler = new FormatCompiler() { RemoveNewLines = templateSettings.RemoveNewLines };
            compiler.RegisterTag(new DehumanizeTagDefinition(), true);
            compiler.RegisterTag(new TypeMapTagDefinition(), true);

            var generator = compiler.Compile(templateContents);
            m_templateGenerators.Add(templatePath, generator);
            return generator;
        }
    }
}
