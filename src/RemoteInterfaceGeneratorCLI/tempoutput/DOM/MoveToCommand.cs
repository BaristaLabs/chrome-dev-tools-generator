namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Moves node into the new container, places it before the given anchor.
    /// </summary>
    public sealed class MoveToCommand : ICommand<MoveToCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.moveTo";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of the node to move.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Id of the element to drop the moved node into.
        /// </summary>
        
        [JsonProperty("targetNodeId")]
        public long TargetNodeId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Drop node before this one (if absent, the moved node becomes the last child of <code>targetNodeId</code>).
        /// </summary>
        
        [JsonProperty("insertBeforeNodeId")]
        public long InsertBeforeNodeId
        {
            get;
            set;
        }
    
    }

    public sealed class MoveToCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// New id of the moved node.
        ///</summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
    }
}