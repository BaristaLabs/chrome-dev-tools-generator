namespace BaristaLabs.ChromeDevTools.Runtime.DOMStorage
{
    /// <summary>
    /// DOM Storage identifier.
    /// </summary>
    public sealed class StorageId
    {
    
        /// <summary>
        /// Security origin for the storage.
        ///</summary>
        public string SecurityOrigin
        {
            get;
            set;
        }
    
        /// <summary>
        /// Whether the storage is local storage (not session storage).
        ///</summary>
        public bool IsLocalStorage
        {
            get;
            set;
        }
    
    }
}