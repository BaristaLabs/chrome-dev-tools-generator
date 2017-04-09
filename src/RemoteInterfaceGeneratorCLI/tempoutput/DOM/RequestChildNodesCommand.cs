namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Requests that children of the node with given id are returned to the caller in form of <code>setChildNodes</code> events where not only immediate children are retrieved, but all children down to the specified depth.
    /// </summary>
    public sealed class RequestChildNodesCommand : ICommand<RequestChildNodesCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.requestChildNodes";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of the node to get children for.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// The maximum depth at which children should be retrieved, defaults to 1. Use -1 for the entire subtree or provide an integer larger than 0.
        /// </summary>
        
        [JsonProperty("depth")]
        public long Depth
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Whether or not iframes and shadow roots should be traversed when returning the sub-tree (default is false).
        /// </summary>
        
        [JsonProperty("pierce")]
        public bool Pierce
        {
            get;
            set;
        }
    
    }

    public sealed class RequestChildNodesCommandResponse : ICommandResponse
    {
    
    }
}