namespace BaristaLabs.ChromeDevTools.Runtime.CacheStorage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Deletes a cache entry.
    /// </summary>
    public sealed class DeleteEntryCommand : ICommand<DeleteEntryCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CacheStorage.deleteEntry";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of cache where the entry will be deleted.
        /// </summary>
        
        [JsonProperty("cacheId")]
        public string CacheId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// URL spec of the request.
        /// </summary>
        
        [JsonProperty("request")]
        public string Request
        {
            get;
            set;
        }
    
    }

    public sealed class DeleteEntryCommandResponse : ICommandResponse
    {
    
    }
}