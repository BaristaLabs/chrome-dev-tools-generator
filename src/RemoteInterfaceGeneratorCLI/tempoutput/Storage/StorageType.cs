namespace BaristaLabs.ChromeDevTools.Runtime.Storage
{
    /// <summary>
    /// Enum of possible storage types.
    /// </summary>
    public sealed class StorageType
    {
        private string m_value;

        private StorageType(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static StorageType Appcache = new StorageType("appcache");
    
        public static StorageType Cookies = new StorageType("cookies");
    
        public static StorageType FileSystems = new StorageType("file_systems");
    
        public static StorageType Indexeddb = new StorageType("indexeddb");
    
        public static StorageType LocalStorage = new StorageType("local_storage");
    
        public static StorageType ShaderCache = new StorageType("shader_cache");
    
        public static StorageType Websql = new StorageType("websql");
    
        public static StorageType ServiceWorkers = new StorageType("service_workers");
    
        public static StorageType CacheStorage = new StorageType("cache_storage");
    
        public static StorageType All = new StorageType("all");
    
    }
}