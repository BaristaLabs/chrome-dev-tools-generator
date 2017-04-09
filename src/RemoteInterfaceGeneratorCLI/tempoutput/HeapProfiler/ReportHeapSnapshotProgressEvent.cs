namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class ReportHeapSnapshotProgressEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the done
        /// </summary>
        
        public long Done
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the total
        /// </summary>
        
        public long Total
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the finished
        /// </summary>
        
        public bool Finished
        {
            get;
            set;
        }
    
    }
}