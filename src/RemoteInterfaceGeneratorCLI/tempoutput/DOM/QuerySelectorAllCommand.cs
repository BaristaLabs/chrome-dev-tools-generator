namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Executes <code>querySelectorAll</code> on a given node.
    /// </summary>
    public sealed class QuerySelectorAllCommand : ICommand<QuerySelectorAllCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.querySelectorAll";
        
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

    public sealed class QuerySelectorAllCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Query selector result.
        ///</summary>
        
        [JsonProperty("nodeIds")]
        public long[] NodeIds
        {
            get;
            set;
        }
    
    }
}