namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets the new stylesheet text.
    /// </summary>
    public sealed class SetStyleSheetTextCommand : ICommand<SetStyleSheetTextCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.setStyleSheetText";
        
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
        /// Gets or sets the text
        /// </summary>
        
        [JsonProperty("text")]
        public string Text
        {
            get;
            set;
        }
    
    }

    public sealed class SetStyleSheetTextCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// URL of source map associated with script (if any).
        ///</summary>
        
        [JsonProperty("sourceMapURL")]
        public string SourceMapURL
        {
            get;
            set;
        }
    
    }
}