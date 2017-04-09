namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    /// <summary>
    /// Layout viewport position and dimensions.
    /// </summary>
    public sealed class LayoutViewport
    {
    
        /// <summary>
        /// Horizontal offset relative to the document (CSS pixels).
        ///</summary>
        public long PageX
        {
            get;
            set;
        }
    
        /// <summary>
        /// Vertical offset relative to the document (CSS pixels).
        ///</summary>
        public long PageY
        {
            get;
            set;
        }
    
        /// <summary>
        /// Width (CSS pixels), excludes scrollbar if present.
        ///</summary>
        public long ClientWidth
        {
            get;
            set;
        }
    
        /// <summary>
        /// Height (CSS pixels), excludes scrollbar if present.
        ///</summary>
        public long ClientHeight
        {
            get;
            set;
        }
    
    }
}