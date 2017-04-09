namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Tells whether emulation of network conditions is supported.
    /// </summary>
    public sealed class CanEmulateNetworkConditionsCommand : ICommand<CanEmulateNetworkConditionsCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Network.canEmulateNetworkConditions";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class CanEmulateNetworkConditionsCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// True if emulation of network conditions is supported.
        ///</summary>
        
        [JsonProperty("result")]
        public bool Result
        {
            get;
            set;
        }
    
    }
}