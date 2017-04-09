namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the computed style for a DOM node identified by <code>nodeId</code>.
    /// </summary>
    public sealed class GetComputedStyleForNodeCommand : ICommand<GetComputedStyleForNodeCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.getComputedStyleForNode";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Gets or sets the nodeId
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
    }

    public sealed class GetComputedStyleForNodeCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Computed style for the specified DOM node.
        ///</summary>
        
        [JsonProperty("computedStyle")]
        public CSSComputedStyleProperty[] ComputedStyle
        {
            get;
            set;
        }
    
    }
}