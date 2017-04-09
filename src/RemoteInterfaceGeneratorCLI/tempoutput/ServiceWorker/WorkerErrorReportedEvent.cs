namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class WorkerErrorReportedEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the errorMessage
        /// </summary>
        
        public ServiceWorkerErrorMessage ErrorMessage
        {
            get;
            set;
        }
    
    }
}