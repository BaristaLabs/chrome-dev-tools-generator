namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    /// <summary>
    /// Fired when <code>Container</code>'s child node count has changed.
    /// </summary>
    public sealed class ChildNodeCountUpdatedEvent : IEvent
    {
    
        
        /// <summary>
        /// Id of the node that has changed.
        /// </summary>
        
        public long NodeId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// New node count.
        /// </summary>
        
        public long ChildNodeCount
        {
            get;
            set;
        }
    
    }
}