namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    /// <summary>
    /// Information about the Resource on the page.
    /// </summary>
    public sealed class FrameResource
    {
    
        /// <summary>
        /// Resource URL.
        ///</summary>
        public string Url
        {
            get;
            set;
        }
    
        /// <summary>
        /// Type of this resource.
        ///</summary>
        public ResourceType Type
        {
            get;
            set;
        }
    
        /// <summary>
        /// Resource mimeType as determined by the browser.
        ///</summary>
        public string MimeType
        {
            get;
            set;
        }
    
        /// <summary>
        /// last-modified timestamp as reported by server.
        ///</summary>
        public double LastModified
        {
            get;
            set;
        }
    
        /// <summary>
        /// Resource content size.
        ///</summary>
        public double ContentSize
        {
            get;
            set;
        }
    
        /// <summary>
        /// True if the resource failed to load.
        ///</summary>
        public bool Failed
        {
            get;
            set;
        }
    
        /// <summary>
        /// True if the resource was canceled during loading.
        ///</summary>
        public bool Canceled
        {
            get;
            set;
        }
    
    }
}