namespace BaristaLabs.ChromeDevTools.Runtime.ApplicationCache
{
    /// <summary>
    /// Frame identifier - manifest URL pair.
    /// </summary>
    public sealed class FrameWithManifest
    {
    
        /// <summary>
        /// Frame identifier.
        ///</summary>
        public string FrameId
        {
            get;
            set;
        }
    
        /// <summary>
        /// Manifest URL.
        ///</summary>
        public string ManifestURL
        {
            get;
            set;
        }
    
        /// <summary>
        /// Application cache status.
        ///</summary>
        public long Status
        {
            get;
            set;
        }
    
    }
}