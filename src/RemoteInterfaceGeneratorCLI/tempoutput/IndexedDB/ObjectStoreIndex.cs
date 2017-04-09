namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    /// <summary>
    /// Object store index.
    /// </summary>
    public sealed class ObjectStoreIndex
    {
    
        /// <summary>
        /// Index name.
        ///</summary>
        public string Name
        {
            get;
            set;
        }
    
        /// <summary>
        /// Index key path.
        ///</summary>
        public KeyPath KeyPath
        {
            get;
            set;
        }
    
        /// <summary>
        /// If true, index is unique.
        ///</summary>
        public bool Unique
        {
            get;
            set;
        }
    
        /// <summary>
        /// If true, index allows multiple entries for a key.
        ///</summary>
        public bool MultiEntry
        {
            get;
            set;
        }
    
    }
}