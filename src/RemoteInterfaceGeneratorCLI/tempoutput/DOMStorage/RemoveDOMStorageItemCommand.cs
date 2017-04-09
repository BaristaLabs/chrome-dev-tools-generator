namespace BaristaLabs.ChromeDevTools.Runtime.DOMStorage
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class RemoveDOMStorageItemCommand : ICommand<RemoveDOMStorageItemCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOMStorage.removeDOMStorageItem";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Gets or sets the storageId
        /// </summary>
        
        [JsonProperty("storageId")]
        public StorageId StorageId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the key
        /// </summary>
        
        [JsonProperty("key")]
        public string Key
        {
            get;
            set;
        }
    
    }

    public sealed class RemoveDOMStorageItemCommandResponse : ICommandResponse
    {
    
    }
}