namespace BaristaLabs.ChromeDevTools.RemoteInterface.ProtocolDefinition
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public sealed class ProtocolDefinition : IDefinition
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
    }
}
