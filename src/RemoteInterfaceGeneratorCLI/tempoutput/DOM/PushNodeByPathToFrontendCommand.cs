namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Requests that the node is sent to the caller given its path. // FIXME, use XPath
    /// </summary>
    public sealed class PushNodeByPathToFrontendCommand : ICommand<PushNodeByPathToFrontendCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.pushNodeByPathToFrontend";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Path to node in the proprietary format.
        /// </summary>
        
        [JsonProperty("path")]
        public string Path
        {
            get;
            set;
        }
    
    }

    public sealed class PushNodeByPathToFrontendCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Id of the node for given path.
        ///</summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
    }
}