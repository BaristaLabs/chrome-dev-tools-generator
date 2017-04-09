namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Cancels blocking of a specific URL from loading.
    /// </summary>
    public sealed class RemoveBlockedURLCommand : ICommand<RemoveBlockedURLCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Network.removeBlockedURL";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// URL to stop blocking.
        /// </summary>
        
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
    
    }

    public sealed class RemoveBlockedURLCommandResponse : ICommandResponse
    {
    
    }
}