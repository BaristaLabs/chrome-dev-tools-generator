namespace BaristaLabs.ChromeDevTools.RemoteInterface.DebuggerProtocol
{
    using Mustache;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Reflection;
    using System;

    public sealed class ProtocolDefinition : ICodeGenerator
    {
        public ProtocolDefinition()
        {
            Domains = new Collection<DomainDefinition>();
        }

        [JsonProperty(PropertyName = "version", Required = Required.Always)]
        public Version Version
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "domains", Required = Required.Always)]
        public ICollection<DomainDefinition> Domains
        {
            get;
            set;
        }

        public IDictionary<string, string> GenerateCode(CodeGenerationSettings settings)
        {
            foreach (var domain in Domains)
            {
                var commandTemplate = File.ReadAllText($"{settings.TemplatePath}\\command.mustache");

                var compiler = new FormatCompiler() { RemoveNewLines = false };
                Generator generator = compiler.Compile(commandTemplate);
                string result = generator.Render(new
                {
                    domain = domain,
                    rootNamespace = settings.RootNamespace,
                });
            }

            return null;
        }
    }
}
