namespace BaristaLabs.ChromeDevTools.Runtime.DOMStorage
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class DomStorageItemAddedEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the storageId
        /// </summary>
        
        public StorageId StorageId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the key
        /// </summary>
        
        public string Key
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the newValue
        /// </summary>
        
        public string NewValue
        {
            get;
            set;
        }
    
    }
}