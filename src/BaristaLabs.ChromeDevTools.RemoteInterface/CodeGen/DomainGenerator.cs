namespace BaristaLabs.ChromeDevTools.RemoteInterface.CodeGen
{
    using BaristaLabs.ChromeDevTools.RemoteInterface.ProtocolDefinition;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public sealed class DomainGenerator : CodeGeneratorBase<DomainDefinition>
    {
        public DomainGenerator(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        public override IDictionary<string, string> GenerateCode(DomainDefinition domainDefinition, CodeGeneratorContext context)
        {
            var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            var typeGenerator = ServiceProvider.GetRequiredService<ICodeGenerator<TypeDefinition>>();
            foreach (var type in domainDefinition.Types)
            {
                typeGenerator.GenerateCode(type, context)
                    .ToList()
                    .ForEach(x => result.Add(x.Key, x.Value));
            }

            var eventGenerator = ServiceProvider.GetRequiredService<ICodeGenerator<EventDefinition>>();
            foreach (var @event in domainDefinition.Events)
            {
                eventGenerator.GenerateCode(@event, context)
                    .ToList()
                    .ForEach(x => result.Add(x.Key, x.Value));
            }

            var commandGenerator = ServiceProvider.GetRequiredService<ICodeGenerator<CommandDefinition>>();
            foreach (var command in domainDefinition.Commands)
            {
                commandGenerator.GenerateCode(command, context)
                    .ToList()
                    .ForEach(x => result.Add(x.Key, x.Value));
            }

            return result;
        }
    }
}
