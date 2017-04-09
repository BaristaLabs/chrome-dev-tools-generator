namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Toggles ignoring cache for each request. If <code>true</code>, cache will not be used.
    /// </summary>
    public sealed class SetCacheDisabledCommand : ICommand<SetCacheDisabledCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Network.setCacheDisabled";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Cache disabled state.
        /// </summary>
        
        [JsonProperty("cacheDisabled")]
        public bool CacheDisabled
        {
            get;
            set;
        }
    
    }

    public sealed class SetCacheDisabledCommandResponse : ICommandResponse
    {
    
    }
}