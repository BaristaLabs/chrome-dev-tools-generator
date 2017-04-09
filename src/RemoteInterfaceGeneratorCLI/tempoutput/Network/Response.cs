namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    /// <summary>
    /// HTTP response data.
    /// </summary>
    public sealed class Response
    {
    
        /// <summary>
        /// Response URL. This URL can be different from CachedResource.url in case of redirect.
        ///</summary>
        public string Url
        {
            get;
            set;
        }
    
        /// <summary>
        /// HTTP response status code.
        ///</summary>
        public double Status
        {
            get;
            set;
        }
    
        /// <summary>
        /// HTTP response status text.
        ///</summary>
        public string StatusText
        {
            get;
            set;
        }
    
        /// <summary>
        /// HTTP response headers.
        ///</summary>
        public Headers Headers
        {
            get;
            set;
        }
    
        /// <summary>
        /// HTTP response headers text.
        ///</summary>
        public string HeadersText
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
        /// Refined HTTP request headers that were actually transmitted over the network.
        ///</summary>
        public Headers RequestHeaders
        {
            get;
            set;
        }
    
        /// <summary>
        /// HTTP request headers text.
        ///</summary>
        public string RequestHeadersText
        {
            get;
            set;
        }
    
        /// <summary>
        /// Specifies whether physical connection was actually reused for this request.
        ///</summary>
        public bool ConnectionReused
        {
            get;
            set;
        }
    
        /// <summary>
        /// Physical connection id that was actually used for this request.
        ///</summary>
        public double ConnectionId
        {
            get;
            set;
        }
    
        /// <summary>
        /// Remote IP address.
        ///</summary>
        public string RemoteIPAddress
        {
            get;
            set;
        }
    
        /// <summary>
        /// Remote port.
        ///</summary>
        public long RemotePort
        {
            get;
            set;
        }
    
        /// <summary>
        /// Specifies that the request was served from the disk cache.
        ///</summary>
        public bool FromDiskCache
        {
            get;
            set;
        }
    
        /// <summary>
        /// Specifies that the request was served from the ServiceWorker.
        ///</summary>
        public bool FromServiceWorker
        {
            get;
            set;
        }
    
        /// <summary>
        /// Total number of bytes received for this request so far.
        ///</summary>
        public double EncodedDataLength
        {
            get;
            set;
        }
    
        /// <summary>
        /// Timing information for the given request.
        ///</summary>
        public ResourceTiming Timing
        {
            get;
            set;
        }
    
        /// <summary>
        /// Protocol used to fetch this request.
        ///</summary>
        public string Protocol
        {
            get;
            set;
        }
    
        /// <summary>
        /// Security state of the request resource.
        ///</summary>
        public BaristaLabs.ChromeDevTools.Runtime.Security.SecurityState SecurityState
        {
            get;
            set;
        }
    
        /// <summary>
        /// Security details for the request.
        ///</summary>
        public SecurityDetails SecurityDetails
        {
            get;
            set;
        }
    
    }
}