namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Requests that the node is sent to the caller given the JavaScript node object reference. All nodes that form the path from the node to the root are also sent to the client as a series of <code>setChildNodes</code> notifications.
    /// </summary>
    public sealed class RequestNodeCommand : ICommand<RequestNodeCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.requestNode";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// JavaScript object id to convert into node.
        /// </summary>
        
        [JsonProperty("objectId")]
        public string ObjectId
        {
            get;
            set;
        }
    
    }

    public sealed class RequestNodeCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Node id for given object.
        ///</summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
    }
}