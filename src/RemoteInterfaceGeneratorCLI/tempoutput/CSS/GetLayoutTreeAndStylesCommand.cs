namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// For the main document and any content documents, return the LayoutTreeNodes and a whitelisted subset of the computed style. It only returns pushed nodes, on way to pull all nodes is to call DOM.getDocument with a depth of -1.
    /// </summary>
    public sealed class GetLayoutTreeAndStylesCommand : ICommand<GetLayoutTreeAndStylesCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.getLayoutTreeAndStyles";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Whitelist of computed styles to return.
        /// </summary>
        
        [JsonProperty("computedStyleWhitelist")]
        public string[] ComputedStyleWhitelist
        {
            get;
            set;
        }
    
    }

    public sealed class GetLayoutTreeAndStylesCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Gets or sets the layoutTreeNodes
        /// </summary>
        
        [JsonProperty("layoutTreeNodes")]
        public LayoutTreeNode[] LayoutTreeNodes
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the computedStyles
        /// </summary>
        
        [JsonProperty("computedStyles")]
        public ComputedStyle[] ComputedStyles
        {
            get;
            set;
        }
    
    }
}