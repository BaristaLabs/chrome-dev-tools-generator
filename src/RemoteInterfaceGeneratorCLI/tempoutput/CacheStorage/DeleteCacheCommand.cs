namespace BaristaLabs.ChromeDevTools.Runtime.CacheStorage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Deletes a cache.
    /// </summary>
    public sealed class DeleteCacheCommand : ICommand<DeleteCacheCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CacheStorage.deleteCache";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of cache for deletion.
        /// </summary>
        
        [JsonProperty("cacheId")]
        public string CacheId
        {
            get;
            set;
        }
    
    }

    public sealed class DeleteCacheCommandResponse : ICommandResponse
    {
    
    }
}