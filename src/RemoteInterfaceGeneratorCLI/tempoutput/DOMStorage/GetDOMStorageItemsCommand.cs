namespace BaristaLabs.ChromeDevTools.Runtime.DOMStorage
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class GetDOMStorageItemsCommand : ICommand<GetDOMStorageItemsCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOMStorage.getDOMStorageItems";
        
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
    
    }

    public sealed class GetDOMStorageItemsCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Gets or sets the entries
        /// </summary>
        
        [JsonProperty("entries")]
        public string[][] Entries
        {
            get;
            set;
        }
    
    }
}