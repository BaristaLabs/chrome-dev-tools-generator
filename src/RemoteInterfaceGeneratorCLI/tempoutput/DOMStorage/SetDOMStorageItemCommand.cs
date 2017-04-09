namespace BaristaLabs.ChromeDevTools.Runtime.DOMStorage
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class SetDOMStorageItemCommand : ICommand<SetDOMStorageItemCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOMStorage.setDOMStorageItem";
        
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
    
        
        /// <summary>
        /// Gets or sets the value
        /// </summary>
        
        [JsonProperty("value")]
        public string Value
        {
            get;
            set;
        }
    
    }

    public sealed class SetDOMStorageItemCommandResponse : ICommandResponse
    {
    
    }
}