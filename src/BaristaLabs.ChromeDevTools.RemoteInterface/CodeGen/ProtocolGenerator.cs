namespace BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen
{
    using BaristaLabs.ChromeDevTools.RemoteInterface.ProtocolDefinition;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;
    using Mustache;
    using System.Linq;

    public static class ProtocolGenerator
    {
        public static IDictionary<string, string> Generate(string settingsFilePath, ProtocolDefinition definition)
        {
            if (!File.Exists(settingsFilePath))
                throw new FileNotFoundException($"The specified settings file ({settingsFilePath}) could not be found. Please check that the settings file exists.");

            var settingsJson = File.ReadAllText(settingsFilePath);
            var settings = JsonConvert.DeserializeObject<CodeGenerationSettings>(settingsJson);

            if (String.IsNullOrWhiteSpace(settings.TemplatesPath))
            {
                settings.TemplatesPath = Path.GetDirectoryName(settingsFilePath);
            }

            var includeData = new {
                rootNamespace = settings.RootNamespace
            };

            var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            foreach (var include in settings.Include)
            {
                var includeCodeGenerator = TemplatesManager.GetGeneratorForTemplate($"{settings.TemplatesPath}\\{include.Key}");
                var includeCodeResult = includeCodeGenerator.Render(includeData);
                result.Add($"{settings.OutputPath}\\{include.Value}", includeCodeResult);
            }

            definition.GenerateCode(settings, null)
                .ToList()
                .ForEach(x => result.Add(x.Key, x.Value));

            return result;
        }
    }
}
