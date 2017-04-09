namespace BaristaLabs.ChromeDevTools.Runtime.ApplicationCache
{
    /// <summary>
    /// Detailed application cache resource information.
    /// </summary>
    public sealed class ApplicationCacheResource
    {
    
        /// <summary>
        /// Resource url.
        ///</summary>
        public string Url
        {
            get;
            set;
        }
    
        /// <summary>
        /// Resource size.
        ///</summary>
        public long Size
        {
            get;
            set;
        }
    
        /// <summary>
        /// Resource type.
        ///</summary>
        public string Type
        {
            get;
            set;
        }
    
    }
}