namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the id of the nearest ancestor that is a relayout boundary.
    /// </summary>
    public sealed class GetRelayoutBoundaryCommand : ICommand<GetRelayoutBoundaryCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.getRelayoutBoundary";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of the node.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
    }

    public sealed class GetRelayoutBoundaryCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Relayout boundary node id for the given node.
        ///</summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
    }
}