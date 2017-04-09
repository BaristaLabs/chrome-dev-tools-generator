namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    using Newtonsoft.Json;

    /// <summary>
    /// Fetches the accessibility node and partial accessibility tree for this DOM node, if it exists.
    /// </summary>
    public sealed class GetPartialAXTreeCommand : ICommand<GetPartialAXTreeCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Accessibility.getPartialAXTree";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// ID of node to get the partial accessibility tree for.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Whether to fetch this nodes ancestors, siblings and children. Defaults to true.
        /// </summary>
        
        [JsonProperty("fetchRelatives")]
        public bool FetchRelatives
        {
            get;
            set;
        }
    
    }

    public sealed class GetPartialAXTreeCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// The <code>Accessibility.AXNode</code> for this DOM node, if it exists, plus its ancestors, siblings and children, if requested.
        ///</summary>
        
        [JsonProperty("nodes")]
        public AXNode[] Nodes
        {
            get;
            set;
        }
    
    }
}