namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Toggles navigation throttling which allows programatic control over navigation and redirect response.
    /// </summary>
    public sealed class SetControlNavigationsCommand : ICommand<SetControlNavigationsCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.setControlNavigations";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Gets or sets the enabled
        /// </summary>
        
        [JsonProperty("enabled")]
        public bool Enabled
        {
            get;
            set;
        }
    
    }

    public sealed class SetControlNavigationsCommandResponse : ICommandResponse
    {
    
    }
}