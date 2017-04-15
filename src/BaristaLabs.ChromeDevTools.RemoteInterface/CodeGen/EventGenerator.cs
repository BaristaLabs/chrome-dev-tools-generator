namespace BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen
{
    using BaristaLabs.ChromeDevTools.RemoteInterface.ProtocolDefinition;
    using Humanizer;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Generates code for Event Definitions
    /// </summary>
    public sealed class EventGenerator : CodeGeneratorBase<EventDefinition>
    {
        public EventGenerator(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        public override IDictionary<string, string> GenerateCode(EventDefinition eventDefinition, CodeGeneratorContext context)
        {
            var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            if (String.IsNullOrWhiteSpace(Settings.DefinitionTemplates.EventTemplate.TemplatePath))
                return result;

            var eventGenerator = TemplatesManager.GetGeneratorForTemplate(Settings.DefinitionTemplates.EventTemplate);

            var className = eventDefinition.Name.Dehumanize();

            string codeResult = eventGenerator.Render(new
            {
                @event = eventDefinition,
                className = className,
                domain = context.Domain,
                rootNamespace = Settings.RootNamespace,
                context = context
            });

            var outputPath = Utility.ReplaceTokensInPath(Settings.DefinitionTemplates.EventTemplate.OutputPath, className, context, Settings);
            result.Add(outputPath, codeResult);

            return result;
        }
    }
}
