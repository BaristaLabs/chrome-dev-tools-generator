namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    /// <summary>
    /// Mirrors <code>DOMCharacterDataModified</code> event.
    /// </summary>
    public sealed class CharacterDataModifiedEvent : IEvent
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
        /// New text value.
        /// </summary>
        
        public string CharacterData
        {
            get;
            set;
        }
    
    }
}