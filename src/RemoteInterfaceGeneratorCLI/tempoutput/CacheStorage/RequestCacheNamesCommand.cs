namespace BaristaLabs.ChromeDevTools.Runtime.CacheStorage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Requests cache names.
    /// </summary>
    public sealed class RequestCacheNamesCommand : ICommand<RequestCacheNamesCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CacheStorage.requestCacheNames";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Security origin.
        /// </summary>
        
        [JsonProperty("securityOrigin")]
        public string SecurityOrigin
        {
            get;
            set;
        }
    
    }

    public sealed class RequestCacheNamesCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Caches for the security origin.
        ///</summary>
        
        [JsonProperty("caches")]
        public Cache[] Caches
        {
            get;
            set;
        }
    
    }
}