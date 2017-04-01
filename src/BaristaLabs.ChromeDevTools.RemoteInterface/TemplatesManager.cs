namespace BaristaLabs.ChromeDevTools.RemoteInterface
{
    using Mustache;
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// Represents a class that manages templates and their associated generators.
    /// </summary>
    public static class TemplatesManager
    {
        private static IDictionary<string, Generator> s_templateGenerators = new Dictionary<string, Generator>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Returns a generator singleton for the specified template path.
        /// </summary>
        /// <param name="templatePath"></param>
        /// <returns></returns>
        public static Generator GetGeneratorForTemplate(string templatePath)
        {
            if (s_templateGenerators.ContainsKey(templatePath))
                return s_templateGenerators[templatePath];

            if (!File.Exists(templatePath))
                throw new FileNotFoundException($"Unable to locate a template at {templatePath} - please ensure that a template file exists at this location.");

            var templateContents = File.ReadAllText(templatePath);

            var compiler = new FormatCompiler() { RemoveNewLines = false };
            compiler.RegisterTag(new DehumanizeTagDefinition(), true);
            compiler.RegisterTag(new TypeMapTagDefinition(), true);

            var generator = compiler.Compile(templateContents);
            s_templateGenerators.Add(templatePath, generator);
            return generator;
        }
    }
}
