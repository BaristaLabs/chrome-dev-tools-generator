namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    /// <summary>
    /// Mirrors <code>DOMNodeInserted</code> event.
    /// </summary>
    public sealed class ChildNodeInsertedEvent : IEvent
    {
    
        
        /// <summary>
        /// Id of the node that has changed.
        /// </summary>
        
        public long ParentNodeId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// If of the previous siblint.
        /// </summary>
        
        public long PreviousNodeId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Inserted node data.
        /// </summary>
        
        public Node Node
        {
            get;
            set;
        }
    
    }
}