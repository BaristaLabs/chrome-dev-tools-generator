namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    /// <summary>
    /// WebSocket response data.
    /// </summary>
    public sealed class WebSocketResponse
    {
    
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
        /// HTTP request headers.
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
    
    }
}