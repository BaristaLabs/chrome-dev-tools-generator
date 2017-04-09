namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class AddHeapSnapshotChunkEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the chunk
        /// </summary>
        
        public string Chunk
        {
            get;
            set;
        }
    
    }
}