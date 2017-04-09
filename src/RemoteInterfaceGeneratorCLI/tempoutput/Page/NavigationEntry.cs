namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    /// <summary>
    /// Navigation history entry.
    /// </summary>
    public sealed class NavigationEntry
    {
    
        /// <summary>
        /// Unique id of the navigation history entry.
        ///</summary>
        public long Id
        {
            get;
            set;
        }
    
        /// <summary>
        /// URL of the navigation history entry.
        ///</summary>
        public string Url
        {
            get;
            set;
        }
    
        /// <summary>
        /// Title of the navigation history entry.
        ///</summary>
        public string Title
        {
            get;
            set;
        }
    
    }
}