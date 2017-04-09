namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    /// <summary>
    /// Fired when <code>Element</code>'s attribute is removed.
    /// </summary>
    public sealed class AttributeRemovedEvent : IEvent
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
        /// A ttribute name.
        /// </summary>
        
        public string Name
        {
            get;
            set;
        }
    
    }
}