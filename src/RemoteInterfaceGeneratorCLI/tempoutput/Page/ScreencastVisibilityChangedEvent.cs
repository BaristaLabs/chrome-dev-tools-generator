namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    /// <summary>
    /// Fired when the page with currently enabled screencast was shown or hidden </code>.
    /// </summary>
    public sealed class ScreencastVisibilityChangedEvent : IEvent
    {
    
        
        /// <summary>
        /// True if the page is visible.
        /// </summary>
        
        public bool Visible
        {
            get;
            set;
        }
    
    }
}