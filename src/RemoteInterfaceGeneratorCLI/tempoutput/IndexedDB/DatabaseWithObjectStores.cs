namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    /// <summary>
    /// Database with an array of object stores.
    /// </summary>
    public sealed class DatabaseWithObjectStores
    {
    
        /// <summary>
        /// Database name.
        ///</summary>
        public string Name
        {
            get;
            set;
        }
    
        /// <summary>
        /// Database version.
        ///</summary>
        public long Version
        {
            get;
            set;
        }
    
        /// <summary>
        /// Object stores in this database.
        ///</summary>
        public ObjectStore[] ObjectStores
        {
            get;
            set;
        }
    
    }
}