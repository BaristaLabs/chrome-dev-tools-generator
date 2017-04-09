namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Navigates current page to the given URL.
    /// </summary>
    public sealed class NavigateCommand : ICommand<NavigateCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.navigate";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// URL to navigate the page to.
        /// </summary>
        
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
    
    }

    public sealed class NavigateCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Frame id that will be navigated.
        ///</summary>
        
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
    
    }
}