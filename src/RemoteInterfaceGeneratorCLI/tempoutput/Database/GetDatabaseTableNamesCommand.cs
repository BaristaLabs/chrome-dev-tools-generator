namespace BaristaLabs.ChromeDevTools.Runtime.Database
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class GetDatabaseTableNamesCommand : ICommand<GetDatabaseTableNamesCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Database.getDatabaseTableNames";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Gets or sets the databaseId
        /// </summary>
        
        [JsonProperty("databaseId")]
        public string DatabaseId
        {
            get;
            set;
        }
    
    }

    public sealed class GetDatabaseTableNamesCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Gets or sets the tableNames
        /// </summary>
        
        [JsonProperty("tableNames")]
        public string[] TableNames
        {
            get;
            set;
        }
    
    }
}