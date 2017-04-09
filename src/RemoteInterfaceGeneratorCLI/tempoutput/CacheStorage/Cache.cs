namespace BaristaLabs.ChromeDevTools.Runtime.CacheStorage
{
    /// <summary>
    /// Cache identifier.
    /// </summary>
    public sealed class Cache
    {
    
        /// <summary>
        /// An opaque unique id of the cache.
        ///</summary>
        public string CacheId
        {
            get;
            set;
        }
    
        /// <summary>
        /// Security origin of the cache.
        ///</summary>
        public string SecurityOrigin
        {
            get;
            set;
        }
    
        /// <summary>
        /// The name of the cache.
        ///</summary>
        public string CacheName
        {
            get;
            set;
        }
    
    }
}