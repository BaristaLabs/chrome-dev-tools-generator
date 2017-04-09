namespace BaristaLabs.ChromeDevTools.Runtime.CacheStorage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Requests data from cache.
    /// </summary>
    public sealed class RequestEntriesCommand : ICommand<RequestEntriesCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CacheStorage.requestEntries";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// ID of cache to get entries from.
        /// </summary>
        
        [JsonProperty("cacheId")]
        public string CacheId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Number of records to skip.
        /// </summary>
        
        [JsonProperty("skipCount")]
        public long SkipCount
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Number of records to fetch.
        /// </summary>
        
        [JsonProperty("pageSize")]
        public long PageSize
        {
            get;
            set;
        }
    
    }

    public sealed class RequestEntriesCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Array of object store data entries.
        ///</summary>
        
        [JsonProperty("cacheDataEntries")]
        public DataEntry[] CacheDataEntries
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// If true, there are more entries to fetch in the given range.
        ///</summary>
        
        [JsonProperty("hasMore")]
        public bool HasMore
        {
            get;
            set;
        }
    
    }
}