namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Creates a new page.
    /// </summary>
    public sealed class CreateTargetCommand : ICommand<CreateTargetCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Target.createTarget";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// The initial URL the page will be navigated to.
        /// </summary>
        
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Frame width in DIP (headless chrome only).
        /// </summary>
        
        [JsonProperty("width")]
        public long Width
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Frame height in DIP (headless chrome only).
        /// </summary>
        
        [JsonProperty("height")]
        public long Height
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// The browser context to create the page in (headless chrome only).
        /// </summary>
        
        [JsonProperty("browserContextId")]
        public string BrowserContextId
        {
            get;
            set;
        }
    
    }

    public sealed class CreateTargetCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// The id of the page opened.
        ///</summary>
        
        [JsonProperty("targetId")]
        public string TargetId
        {
            get;
            set;
        }
    
    }
}