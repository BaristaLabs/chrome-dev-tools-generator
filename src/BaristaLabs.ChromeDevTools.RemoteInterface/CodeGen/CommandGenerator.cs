namespace BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen
{
    using BaristaLabs.ChromeDevTools.RemoteInterface.ProtocolDefinition;
    using Humanizer;
    using System;
    using System.Collections.Generic;

    public sealed class CommandGenerator : CodeGeneratorBase<CommandDefinition>
    {
        public CommandGenerator(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        public override IDictionary<string, string> GenerateCode(CommandDefinition commandDefinition, dynamic options)
        {
            var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            var commandGenerator = TemplatesManager.GetGeneratorForTemplate(Settings.Templates.CommandTemplate);

            var className = commandDefinition.Name.Dehumanize();
            string codeResult = commandGenerator.Render(new
            {
                command = commandDefinition,
                className = className,
                domain = options.domain,
                knownTypes = options.knownTypes,
                rootNamespace = Settings.RootNamespace,
            });

            result.Add($"{Settings.OutputPath}\\{options.domain.Name}\\{className}Command.cs", codeResult);
            return result;
        }
    }
}
