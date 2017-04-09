namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    /// <summary>
    /// ServiceWorker registration.
    /// </summary>
    public sealed class ServiceWorkerRegistration
    {
    
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
        public string ScopeURL
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        public bool IsDeleted
        {
            get;
            set;
        }
    
    }
}