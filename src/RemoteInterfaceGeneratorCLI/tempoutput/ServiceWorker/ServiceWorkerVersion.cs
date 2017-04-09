namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    /// <summary>
    /// ServiceWorker version.
    /// </summary>
    public sealed class ServiceWorkerVersion
    {
    
        /// <summary>
        /// 
        ///</summary>
        public string VersionId
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        public string RegistrationId
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        public string ScriptURL
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        public ServiceWorkerVersionRunningStatus RunningStatus
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        public ServiceWorkerVersionStatus Status
        {
            get;
            set;
        }
    
        /// <summary>
        /// The Last-Modified header value of the main script.
        ///</summary>
        public double ScriptLastModified
        {
            get;
            set;
        }
    
        /// <summary>
        /// The time at which the response headers of the main script were received from the server.  For cached script it is the last time the cache entry was validated.
        ///</summary>
        public double ScriptResponseTime
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        public string ControlledClients
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        public string TargetId
        {
            get;
            set;
        }
    
    }
}