namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Executes <code>querySelector</code> on a given node.
    /// </summary>
    public sealed class QuerySelectorCommand : ICommand<QuerySelectorCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.querySelector";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of the node to query upon.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Selector string.
        /// </summary>
        
        [JsonProperty("selector")]
        public string Selector
        {
            get;
            set;
        }
    
    }

    public sealed class QuerySelectorCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Query selector result.
        ///</summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
    }
}