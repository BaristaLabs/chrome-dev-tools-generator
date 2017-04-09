namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Resolves JavaScript node object for given node id.
    /// </summary>
    public sealed class ResolveNodeCommand : ICommand<ResolveNodeCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.resolveNode";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of the node to resolve.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Symbolic group name that can be used to release multiple objects.
        /// </summary>
        
        [JsonProperty("objectGroup")]
        public string ObjectGroup
        {
            get;
            set;
        }
    
    }

    public sealed class ResolveNodeCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// JavaScript object wrapper for given node.
        ///</summary>
        
        [JsonProperty("object")]
        public BaristaLabs.ChromeDevTools.Runtime.Runtime.RemoteObject Object
        {
            get;
            set;
        }
    
    }
}