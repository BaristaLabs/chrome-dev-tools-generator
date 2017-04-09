namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Activates emulation of network conditions.
    /// </summary>
    public sealed class EmulateNetworkConditionsCommand : ICommand<EmulateNetworkConditionsCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Network.emulateNetworkConditions";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// True to emulate internet disconnection.
        /// </summary>
        
        [JsonProperty("offline")]
        public bool Offline
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Additional latency (ms).
        /// </summary>
        
        [JsonProperty("latency")]
        public double Latency
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Maximal aggregated download throughput.
        /// </summary>
        
        [JsonProperty("downloadThroughput")]
        public double DownloadThroughput
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Maximal aggregated upload throughput.
        /// </summary>
        
        [JsonProperty("uploadThroughput")]
        public double UploadThroughput
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Connection type if known.
        /// </summary>
        
        [JsonProperty("connectionType")]
        public ConnectionType ConnectionType
        {
            get;
            set;
        }
    
    }

    public sealed class EmulateNetworkConditionsCommandResponse : ICommandResponse
    {
    
    }
}