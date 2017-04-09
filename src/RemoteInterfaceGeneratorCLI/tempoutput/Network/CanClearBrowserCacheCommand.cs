namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Tells whether clearing browser cache is supported.
    /// </summary>
    public sealed class CanClearBrowserCacheCommand : ICommand<CanClearBrowserCacheCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Network.canClearBrowserCache";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class CanClearBrowserCacheCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// True if browser cache can be cleared.
        ///</summary>
        
        [JsonProperty("result")]
        public bool Result
        {
            get;
            set;
        }
    
    }
}