namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    using Newtonsoft.Json;

    /// <summary>
    /// Requests database with given name in given frame.
    /// </summary>
    public sealed class RequestDatabaseCommand : ICommand<RequestDatabaseCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "IndexedDB.requestDatabase";
        
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
    
    }

    public sealed class RequestDatabaseCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Database with an array of object stores.
        ///</summary>
        
        [JsonProperty("databaseWithObjectStores")]
        public DatabaseWithObjectStores DatabaseWithObjectStores
        {
            get;
            set;
        }
    
    }
}