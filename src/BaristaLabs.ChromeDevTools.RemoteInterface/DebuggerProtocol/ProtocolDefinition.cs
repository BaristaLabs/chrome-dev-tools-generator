namespace BaristaLabs.ChromeDevTools.RemoteInterface.DebuggerProtocol
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

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

        public IDictionary<string, string> GenerateCode(CodeGenerationSettings settings, dynamic options)
        {
            var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            foreach (var domain in Domains)
            {
                domain.GenerateCode(settings, null)
                    .ToList()
                    .ForEach(x => result.Add(x.Key, x.Value));
            }

            return result;
        }
    }
}
