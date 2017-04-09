namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets attributes on element with given id. This method is useful when user edits some existing attribute value and types in several attribute name/value pairs.
    /// </summary>
    public sealed class SetAttributesAsTextCommand : ICommand<SetAttributesAsTextCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.setAttributesAsText";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of the element to set attributes for.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Text with a number of attributes. Will parse this text using HTML parser.
        /// </summary>
        
        [JsonProperty("text")]
        public string Text
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Attribute name to replace with new attributes derived from text in case text parsed successfully.
        /// </summary>
        
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
    
    }

    public sealed class SetAttributesAsTextCommandResponse : ICommandResponse
    {
    
    }
}