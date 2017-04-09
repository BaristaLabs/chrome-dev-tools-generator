namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    /// <summary>
    /// Called when a pseudo element is added to an element.
    /// </summary>
    public sealed class PseudoElementAddedEvent : IEvent
    {
    
        
        /// <summary>
        /// Pseudo element's parent element id.
        /// </summary>
        
        public long ParentId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// The added pseudo element.
        /// </summary>
        
        public Node PseudoElement
        {
            get;
            set;
        }
    
    }
}