namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns content of the given resource.
    /// </summary>
    public sealed class GetResourceContentCommand : ICommand<GetResourceContentCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.getResourceContent";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Frame id to get resource for.
        /// </summary>
        
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// URL of the resource to get content for.
        /// </summary>
        
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
    
    }

    public sealed class GetResourceContentCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Resource content.
        ///</summary>
        
        [JsonProperty("content")]
        public string Content
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// True, if content was served as base64.
        ///</summary>
        
        [JsonProperty("base64Encoded")]
        public bool Base64Encoded
        {
            get;
            set;
        }
    
    }
}