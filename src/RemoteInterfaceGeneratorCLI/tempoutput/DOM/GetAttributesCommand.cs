namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns attributes for the specified node.
    /// </summary>
    public sealed class GetAttributesCommand : ICommand<GetAttributesCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.getAttributes";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of the node to retrieve attibutes for.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
    }

    public sealed class GetAttributesCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// An interleaved array of node attribute names and values.
        ///</summary>
        
        [JsonProperty("attributes")]
        public string[] Attributes
        {
            get;
            set;
        }
    
    }
}