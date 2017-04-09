namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Toggles ignoring of service worker for each request.
    /// </summary>
    public sealed class SetBypassServiceWorkerCommand : ICommand<SetBypassServiceWorkerCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Network.setBypassServiceWorker";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Bypass service worker and load from network.
        /// </summary>
        
        [JsonProperty("bypass")]
        public bool Bypass
        {
            get;
            set;
        }
    
    }

    public sealed class SetBypassServiceWorkerCommandResponse : ICommandResponse
    {
    
    }
}