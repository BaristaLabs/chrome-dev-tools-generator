namespace BaristaLabs.ChromeDevTools.Runtime.Tracing
{
    /// <summary>
    /// Signals that tracing is stopped and there is no trace buffers pending flush, all data were delivered via dataCollected events.
    /// </summary>
    public sealed class TracingCompleteEvent : IEvent
    {
    
        
        /// <summary>
        /// A handle of the stream that holds resulting trace data.
        /// </summary>
        
        public string Stream
        {
            get;
            set;
        }
    
    }
}