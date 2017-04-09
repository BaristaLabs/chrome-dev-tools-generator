namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    /// <summary>
    /// Issued when execution context is destroyed.
    /// </summary>
    public sealed class ExecutionContextDestroyedEvent : IEvent
    {
    
        
        /// <summary>
        /// Id of the destroyed context
        /// </summary>
        
        public long ExecutionContextId
        {
            get;
            set;
        }
    
    }
}