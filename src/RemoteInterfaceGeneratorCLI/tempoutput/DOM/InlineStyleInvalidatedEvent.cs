namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    /// <summary>
    /// Fired when <code>Element</code>'s inline style is modified via a CSS property modification.
    /// </summary>
    public sealed class InlineStyleInvalidatedEvent : IEvent
    {
    
        
        /// <summary>
        /// Ids of the nodes for which the inline styles have been invalidated.
        /// </summary>
        
        public long[] NodeIds
        {
            get;
            set;
        }
    
    }
}