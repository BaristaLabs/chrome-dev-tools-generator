namespace BaristaLabs.ChromeDevTools.Runtime.Tracing
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class BufferUsageEvent : IEvent
    {
    
        
        /// <summary>
        /// A number in range [0..1] that indicates the used size of event buffer as a fraction of its total size.
        /// </summary>
        
        public double PercentFull
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// An approximate number of events in the trace log.
        /// </summary>
        
        public double EventCount
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// A number in range [0..1] that indicates the used size of event buffer as a fraction of its total size.
        /// </summary>
        
        public double Value
        {
            get;
            set;
        }
    
    }
}