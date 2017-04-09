namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    /// <summary>
    /// Called when distrubution is changed.
    /// </summary>
    public sealed class DistributedNodesUpdatedEvent : IEvent
    {
    
        
        /// <summary>
        /// Insertion point where distrubuted nodes were updated.
        /// </summary>
        
        public long InsertionPointId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Distributed nodes for given insertion point.
        /// </summary>
        
        public BackendNode[] DistributedNodes
        {
            get;
            set;
        }
    
    }
}