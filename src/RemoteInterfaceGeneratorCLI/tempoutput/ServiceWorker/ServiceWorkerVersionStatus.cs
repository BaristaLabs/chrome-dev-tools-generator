namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class ServiceWorkerVersionStatus
    {
        private string m_value;

        private ServiceWorkerVersionStatus(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static ServiceWorkerVersionStatus New = new ServiceWorkerVersionStatus("new");
    
        public static ServiceWorkerVersionStatus Installing = new ServiceWorkerVersionStatus("installing");
    
        public static ServiceWorkerVersionStatus Installed = new ServiceWorkerVersionStatus("installed");
    
        public static ServiceWorkerVersionStatus Activating = new ServiceWorkerVersionStatus("activating");
    
        public static ServiceWorkerVersionStatus Activated = new ServiceWorkerVersionStatus("activated");
    
        public static ServiceWorkerVersionStatus Redundant = new ServiceWorkerVersionStatus("redundant");
    
    }
}