namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    /// <summary>
    /// Compressed image data requested by the <code>startScreencast</code>.
    /// </summary>
    public sealed class ScreencastFrameEvent : IEvent
    {
    
        
        /// <summary>
        /// Base64-encoded compressed image.
        /// </summary>
        
        public string Data
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Screencast frame metadata.
        /// </summary>
        
        public ScreencastFrameMetadata Metadata
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Frame number.
        /// </summary>
        
        public long SessionId
        {
            get;
            set;
        }
    
    }
}