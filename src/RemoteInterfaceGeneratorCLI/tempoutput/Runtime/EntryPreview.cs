namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class EntryPreview
    {
    
        /// <summary>
        /// Preview of the key. Specified for map-like collection entries.
        ///</summary>
        public ObjectPreview Key
        {
            get;
            set;
        }
    
        /// <summary>
        /// Preview of the value.
        ///</summary>
        public ObjectPreview Value
        {
            get;
            set;
        }
    
    }
}