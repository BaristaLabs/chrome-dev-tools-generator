namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets given markup as the document's HTML.
    /// </summary>
    public sealed class SetDocumentContentCommand : ICommand<SetDocumentContentCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.setDocumentContent";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Frame id to set HTML for.
        /// </summary>
        
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// HTML content to set.
        /// </summary>
        
        [JsonProperty("html")]
        public string Html
        {
            get;
            set;
        }
    
    }

    public sealed class SetDocumentContentCommandResponse : ICommandResponse
    {
    
    }
}