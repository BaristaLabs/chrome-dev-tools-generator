namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    /// <summary>
    /// Timing information for the request.
    /// </summary>
    public sealed class ResourceTiming
    {
    
        /// <summary>
        /// Timing's requestTime is a baseline in seconds, while the other numbers are ticks in milliseconds relatively to this requestTime.
        ///</summary>
        public double RequestTime
        {
            get;
            set;
        }
    
        /// <summary>
        /// Started resolving proxy.
        ///</summary>
        public double ProxyStart
        {
            get;
            set;
        }
    
        /// <summary>
        /// Finished resolving proxy.
        ///</summary>
        public double ProxyEnd
        {
            get;
            set;
        }
    
        /// <summary>
        /// Started DNS address resolve.
        ///</summary>
        public double DnsStart
        {
            get;
            set;
        }
    
        /// <summary>
        /// Finished DNS address resolve.
        ///</summary>
        public double DnsEnd
        {
            get;
            set;
        }
    
        /// <summary>
        /// Started connecting to the remote host.
        ///</summary>
        public double ConnectStart
        {
            get;
            set;
        }
    
        /// <summary>
        /// Connected to the remote host.
        ///</summary>
        public double ConnectEnd
        {
            get;
            set;
        }
    
        /// <summary>
        /// Started SSL handshake.
        ///</summary>
        public double SslStart
        {
            get;
            set;
        }
    
        /// <summary>
        /// Finished SSL handshake.
        ///</summary>
        public double SslEnd
        {
            get;
            set;
        }
    
        /// <summary>
        /// Started running ServiceWorker.
        ///</summary>
        public double WorkerStart
        {
            get;
            set;
        }
    
        /// <summary>
        /// Finished Starting ServiceWorker.
        ///</summary>
        public double WorkerReady
        {
            get;
            set;
        }
    
        /// <summary>
        /// Started sending request.
        ///</summary>
        public double SendStart
        {
            get;
            set;
        }
    
        /// <summary>
        /// Finished sending request.
        ///</summary>
        public double SendEnd
        {
            get;
            set;
        }
    
        /// <summary>
        /// Time the server started pushing request.
        ///</summary>
        public double PushStart
        {
            get;
            set;
        }
    
        /// <summary>
        /// Time the server finished pushing request.
        ///</summary>
        public double PushEnd
        {
            get;
            set;
        }
    
        /// <summary>
        /// Finished receiving response headers.
        ///</summary>
        public double ReceiveHeadersEnd
        {
            get;
            set;
        }
    
    }
}