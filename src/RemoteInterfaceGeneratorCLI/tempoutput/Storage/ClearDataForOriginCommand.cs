namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Clears storage for origin.
    /// </summary>
    public sealed class ClearDataForOriginCommand : ICommand<ClearDataForOriginCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Storage.clearDataForOrigin";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Security origin.
        /// </summary>
        
        [JsonProperty("origin")]
        public string Origin
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Comma separated origin names.
        /// </summary>
        
        [JsonProperty("storageTypes")]
        public string StorageTypes
        {
            get;
            set;
        }
    
    }

    public sealed class ClearDataForOriginCommandResponse : ICommandResponse
    {
    
    }
}