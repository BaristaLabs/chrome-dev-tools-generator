namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    /// <summary>
    /// Fired when backend wants to provide client with the missing DOM structure. This happens upon most of the calls requesting node ids.
    /// </summary>
    public sealed class SetChildNodesEvent : IEvent
    {
    
        
        /// <summary>
        /// Parent node id to populate with children.
        /// </summary>
        
        public long ParentId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Child nodes array.
        /// </summary>
        
        public Node[] Nodes
        {
            get;
            set;
        }
    
    }
}