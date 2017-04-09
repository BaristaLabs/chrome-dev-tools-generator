namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    /// <summary>
    /// Fired when a navigation is started if navigation throttles are enabled.  The navigation will be deferred until processNavigation is called.
    /// </summary>
    public sealed class NavigationRequestedEvent : IEvent
    {
    
        
        /// <summary>
        /// Whether the navigation is taking place in the main frame or in a subframe.
        /// </summary>
        
        public bool IsInMainFrame
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Whether the navigation has encountered a server redirect or not.
        /// </summary>
        
        public bool IsRedirect
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the navigationId
        /// </summary>
        
        public long NavigationId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// URL of requested navigation.
        /// </summary>
        
        public string Url
        {
            get;
            set;
        }
    
    }
}