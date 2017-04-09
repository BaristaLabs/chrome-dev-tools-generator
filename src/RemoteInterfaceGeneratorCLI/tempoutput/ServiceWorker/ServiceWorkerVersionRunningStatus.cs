namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class ServiceWorkerVersionRunningStatus
    {
        private string m_value;

        private ServiceWorkerVersionRunningStatus(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static ServiceWorkerVersionRunningStatus Stopped = new ServiceWorkerVersionRunningStatus("stopped");
    
        public static ServiceWorkerVersionRunningStatus Starting = new ServiceWorkerVersionRunningStatus("starting");
    
        public static ServiceWorkerVersionRunningStatus Running = new ServiceWorkerVersionRunningStatus("running");
    
        public static ServiceWorkerVersionRunningStatus Stopping = new ServiceWorkerVersionRunningStatus("stopping");
    
    }
}