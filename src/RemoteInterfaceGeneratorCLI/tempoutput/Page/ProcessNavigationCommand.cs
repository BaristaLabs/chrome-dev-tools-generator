namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Should be sent in response to a navigationRequested or a redirectRequested event, telling the browser how to handle the navigation.
    /// </summary>
    public sealed class ProcessNavigationCommand : ICommand<ProcessNavigationCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.processNavigation";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Gets or sets the response
        /// </summary>
        
        [JsonProperty("response")]
        public NavigationResponse Response
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the navigationId
        /// </summary>
        
        [JsonProperty("navigationId")]
        public long NavigationId
        {
            get;
            set;
        }
    
    }

    public sealed class ProcessNavigationCommandResponse : ICommandResponse
    {
    
    }
}