namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    /// <summary>
    /// Issued when exception was thrown and unhandled.
    /// </summary>
    public sealed class ExceptionThrownEvent : IEvent
    {
    
        
        /// <summary>
        /// Timestamp of the exception.
        /// </summary>
        
        public double Timestamp
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the exceptionDetails
        /// </summary>
        
        public ExceptionDetails ExceptionDetails
        {
            get;
            set;
        }
    
    }
}