namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    /// <summary>
    /// Issued when unhandled exception was revoked.
    /// </summary>
    public sealed class ExceptionRevokedEvent : IEvent
    {
    
        
        /// <summary>
        /// Reason describing why exception was revoked.
        /// </summary>
        
        public string Reason
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// The id of revoked exception, as reported in <code>exceptionUnhandled</code>.
        /// </summary>
        
        public long ExceptionId
        {
            get;
            set;
        }
    
    }
}