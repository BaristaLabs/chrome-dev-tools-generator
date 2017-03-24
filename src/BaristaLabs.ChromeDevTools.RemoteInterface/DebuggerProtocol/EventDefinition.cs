namespace BaristaLabs.ChromeDevTools.RemoteInterface.DebuggerProtocol
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public sealed class EventDefinition : ProtocolDefinitionItem
    {
        public EventDefinition()
        {
            Parameters = new Collection<TypeDefinition>();
        }

        [JsonProperty(PropertyName = "parameters")]
        public ICollection<TypeDefinition> Parameters
        {
            get;
            set;
        }
    }
}
