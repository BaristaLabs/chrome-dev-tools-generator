namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    /// <summary>
    /// HTTP request data.
    /// </summary>
    public sealed class Request
    {
    
        /// <summary>
        /// Request URL.
        ///</summary>
        public string Url
        {
            get;
            set;
        }
    
        /// <summary>
        /// HTTP request method.
        ///</summary>
        public string Method
        {
            get;
            set;
        }
    
        /// <summary>
        /// HTTP request headers.
        ///</summary>
        public Headers Headers
        {
            get;
            set;
        }
    
        /// <summary>
        /// HTTP POST request data.
        ///</summary>
        public string PostData
        {
            get;
            set;
        }
    
        /// <summary>
        /// The mixed content status of the request, as defined in http://www.w3.org/TR/mixed-content/
        ///</summary>
        public string MixedContentType
        {
            get;
            set;
        }
    
        /// <summary>
        /// Priority of the resource request at the time request is sent.
        ///</summary>
        public ResourcePriority InitialPriority
        {
            get;
            set;
        }
    
        /// <summary>
        /// The referrer policy of the request, as defined in https://www.w3.org/TR/referrer-policy/
        ///</summary>
        public string ReferrerPolicy
        {
            get;
            set;
        }
    
    }
}