namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the current textual content and the URL for a stylesheet.
    /// </summary>
    public sealed class GetStyleSheetTextCommand : ICommand<GetStyleSheetTextCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.getStyleSheetText";
        
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
    
    }

    public sealed class GetStyleSheetTextCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// The stylesheet text.
        ///</summary>
        
        [JsonProperty("text")]
        public string Text
        {
            get;
            set;
        }
    
    }
}