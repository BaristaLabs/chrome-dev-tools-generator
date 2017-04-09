namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Blocks specific URL from loading.
    /// </summary>
    public sealed class AddBlockedURLCommand : ICommand<AddBlockedURLCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Network.addBlockedURL";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// URL to block.
        /// </summary>
        
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
    
    }

    public sealed class AddBlockedURLCommandResponse : ICommandResponse
    {
    
    }
}