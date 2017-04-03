namespace BaristaLabs.ChromeDevTools.RemoteInterface.ProtocolDefinition
{
    using Newtonsoft.Json;

    public abstract class ProtocolDefinitionItem
    {

        [JsonProperty(PropertyName = "deprecated")]
        public bool Deprecated
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "description")]
        public string Description
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "experimental")]
        public bool Experimental
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "name")]
        public virtual string Name
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
