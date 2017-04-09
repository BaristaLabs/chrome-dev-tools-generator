namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    /// <summary>
    /// Information about the cached resource.
    /// </summary>
    public sealed class CachedResource
    {
    
        /// <summary>
        /// Resource URL. This is the url of the original network request.
        ///</summary>
        public string Url
        {
            get;
            set;
        }
    
        /// <summary>
        /// Type of this resource.
        ///</summary>
        public BaristaLabs.ChromeDevTools.Runtime.Page.ResourceType Type
        {
            get;
            set;
        }
    
        /// <summary>
        /// Cached response data.
        ///</summary>
        public Response Response
        {
            get;
            set;
        }
    
        /// <summary>
        /// Cached response body size.
        ///</summary>
        public double BodySize
        {
            get;
            set;
        }
    
    }
}