namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    /// <summary>
    /// Fired when a color has been picked.
    /// </summary>
    public sealed class ColorPickedEvent : IEvent
    {
    
        
        /// <summary>
        /// RGBA of the picked color.
        /// </summary>
        
        public BaristaLabs.ChromeDevTools.Runtime.DOM.RGBA Color
        {
            get;
            set;
        }
    
    }
}