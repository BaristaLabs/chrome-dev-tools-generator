namespace BaristaLabs.ChromeDevTools.Runtime.Inspector
{
    /// <summary>
    /// Fired when remote debugging connection is about to be terminated. Contains detach reason.
    /// </summary>
    public sealed class DetachedEvent : IEvent
    {
    
        
        /// <summary>
        /// The reason why connection has been terminated.
        /// </summary>
        
        public string Reason
        {
            get;
            set;
        }
    
    }
}