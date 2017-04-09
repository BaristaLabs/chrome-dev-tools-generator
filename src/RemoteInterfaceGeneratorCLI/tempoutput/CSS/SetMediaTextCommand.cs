namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Modifies the rule selector.
    /// </summary>
    public sealed class SetMediaTextCommand : ICommand<SetMediaTextCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.setMediaText";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Gets or sets the styleSheetId
        /// </summary>
        
        [JsonProperty("styleSheetId")]
        public string StyleSheetId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the range
        /// </summary>
        
        [JsonProperty("range")]
        public SourceRange Range
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the text
        /// </summary>
        
        [JsonProperty("text")]
        public string Text
        {
            get;
            set;
        }
    
    }

    public sealed class SetMediaTextCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// The resulting CSS media rule after modification.
        ///</summary>
        
        [JsonProperty("media")]
        public CSSMedia Media
        {
            get;
            set;
        }
    
    }
}