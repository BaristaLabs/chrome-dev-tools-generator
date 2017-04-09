namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets node name for a node with given id.
    /// </summary>
    public sealed class SetNodeNameCommand : ICommand<SetNodeNameCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.setNodeName";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of the node to set name for.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// New node's name.
        /// </summary>
        
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
    
    }

    public sealed class SetNodeNameCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// New node's id.
        ///</summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
    }
}