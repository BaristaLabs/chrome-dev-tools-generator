namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Configures overlay.
    /// </summary>
    public sealed class ConfigureOverlayCommand : ICommand<ConfigureOverlayCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.configureOverlay";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Whether overlay should be suspended and not consume any resources.
        /// </summary>
        
        [JsonProperty("suspended")]
        public bool Suspended
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Overlay message to display.
        /// </summary>
        
        [JsonProperty("message")]
        public string Message
        {
            get;
            set;
        }
    
    }

    public sealed class ConfigureOverlayCommandResponse : ICommandResponse
    {
    
    }
}