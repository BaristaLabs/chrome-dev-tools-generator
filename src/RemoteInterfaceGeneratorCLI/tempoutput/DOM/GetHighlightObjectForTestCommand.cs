namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// For testing.
    /// </summary>
    public sealed class GetHighlightObjectForTestCommand : ICommand<GetHighlightObjectForTestCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.getHighlightObjectForTest";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of the node to get highlight object for.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
    }

    public sealed class GetHighlightObjectForTestCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Highlight data for the node.
        ///</summary>
        
        [JsonProperty("highlight")]
        public object Highlight
        {
            get;
            set;
        }
    
    }
}