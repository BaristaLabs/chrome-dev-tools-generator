namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    using Newtonsoft.Json;

    /// <summary>
    /// Requests database names for given security origin.
    /// </summary>
    public sealed class RequestDatabaseNamesCommand : ICommand<RequestDatabaseNamesCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "IndexedDB.requestDatabaseNames";
        
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

    public sealed class RequestDatabaseNamesCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Database names for origin.
        ///</summary>
        
        [JsonProperty("databaseNames")]
        public string[] DatabaseNames
        {
            get;
            set;
        }
    
    }
}