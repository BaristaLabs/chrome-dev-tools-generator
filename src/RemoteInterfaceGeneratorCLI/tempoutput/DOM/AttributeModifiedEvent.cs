namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    /// <summary>
    /// Fired when <code>Element</code>'s attribute is modified.
    /// </summary>
    public sealed class AttributeModifiedEvent : IEvent
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
        /// Attribute name.
        /// </summary>
        
        public string Name
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Attribute value.
        /// </summary>
        
        public string Value
        {
            get;
            set;
        }
    
    }
}