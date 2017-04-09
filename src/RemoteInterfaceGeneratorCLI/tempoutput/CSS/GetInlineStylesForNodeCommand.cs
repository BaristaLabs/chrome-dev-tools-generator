namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the styles defined inline (explicitly in the "style" attribute and implicitly, using DOM attributes) for a DOM node identified by <code>nodeId</code>.
    /// </summary>
    public sealed class GetInlineStylesForNodeCommand : ICommand<GetInlineStylesForNodeCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.getInlineStylesForNode";
        
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

    public sealed class GetInlineStylesForNodeCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Inline style for the specified DOM node.
        ///</summary>
        
        [JsonProperty("inlineStyle")]
        public CSSStyle InlineStyle
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Attribute-defined element style (e.g. resulting from "width=20 height=100%").
        ///</summary>
        
        [JsonProperty("attributesStyle")]
        public CSSStyle AttributesStyle
        {
            get;
            set;
        }
    
    }
}