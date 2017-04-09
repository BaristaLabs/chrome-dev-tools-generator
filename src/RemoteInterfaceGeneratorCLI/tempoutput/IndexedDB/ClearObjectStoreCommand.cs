namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    using Newtonsoft.Json;

    /// <summary>
    /// Clears all entries from an object store.
    /// </summary>
    public sealed class ClearObjectStoreCommand : ICommand<ClearObjectStoreCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "IndexedDB.clearObjectStore";
        
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
    
        
        /// <summary>
        /// Database name.
        /// </summary>
        
        [JsonProperty("databaseName")]
        public string DatabaseName
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Object store name.
        /// </summary>
        
        [JsonProperty("objectStoreName")]
        public string ObjectStoreName
        {
            get;
            set;
        }
    
    }

    public sealed class ClearObjectStoreCommandResponse : ICommandResponse
    {
    
    }
}