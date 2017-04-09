namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    /// <summary>
    /// Fired whenever an active document stylesheet is removed.
    /// </summary>
    public sealed class StyleSheetRemovedEvent : IEvent
    {
    
        
        /// <summary>
        /// Identifier of the removed stylesheet.
        /// </summary>
        
        public string StyleSheetId
        {
            get;
            set;
        }
    
    }
}