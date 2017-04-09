namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets attribute for an element with given id.
    /// </summary>
    public sealed class SetAttributeValueCommand : ICommand<SetAttributeValueCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.setAttributeValue";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of the element to set attribute for.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Attribute name.
        /// </summary>
        
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Attribute value.
        /// </summary>
        
        [JsonProperty("value")]
        public string Value
        {
            get;
            set;
        }
    
    }

    public sealed class SetAttributeValueCommandResponse : ICommandResponse
    {
    
    }
}