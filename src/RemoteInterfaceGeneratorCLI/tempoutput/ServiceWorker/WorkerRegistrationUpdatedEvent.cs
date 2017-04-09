namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class WorkerRegistrationUpdatedEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the registrations
        /// </summary>
        
        public ServiceWorkerRegistration[] Registrations
        {
            get;
            set;
        }
    
    }
}