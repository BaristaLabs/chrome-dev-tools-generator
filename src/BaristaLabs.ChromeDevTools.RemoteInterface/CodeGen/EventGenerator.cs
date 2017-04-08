namespace BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen
{
    using BaristaLabs.ChromeDevTools.RemoteInterface.ProtocolDefinition;
    using Humanizer;
    using System;
    using System.Collections.Generic;
    using System.IO;

    public sealed class EventGenerator : CodeGeneratorBase<EventDefinition>
    {
        public EventGenerator(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        public override IDictionary<string, string> GenerateCode(EventDefinition eventDefinition, dynamic options)
        {
            var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            var eventGenerator = TemplatesManager.GetGeneratorForTemplate(Settings.DefinitionTemplates.EventTemplate);

            var className = eventDefinition.Name.Dehumanize();
            string codeResult = eventGenerator.Render(new
            {
                @event = eventDefinition,
                className = className,
                domain = options.domain,
                knownTypes = options.knownTypes,
                rootNamespace = Settings.RootNamespace,
            });

            result.Add(Path.Combine(options.domain.Name, $"{className}Event.cs"), codeResult);

            return result;
        }
    }
}
