namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    /// <summary>
    /// If heap objects tracking has been started then backend regulary sends a current value for last seen object id and corresponding timestamp. If the were changes in the heap since last event then one or more heapStatsUpdate events will be sent before a new lastSeenObjectId event.
    /// </summary>
    public sealed class LastSeenObjectIdEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the lastSeenObjectId
        /// </summary>
        
        public long LastSeenObjectId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the timestamp
        /// </summary>
        
        public double Timestamp
        {
            get;
            set;
        }
    
    }
}