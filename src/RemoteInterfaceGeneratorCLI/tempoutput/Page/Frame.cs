namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    /// <summary>
    /// Information about the Frame on the page.
    /// </summary>
    public sealed class Frame
    {
    
        /// <summary>
        /// Frame unique identifier.
        ///</summary>
        public string Id
        {
            get;
            set;
        }
    
        /// <summary>
        /// Parent frame identifier.
        ///</summary>
        public string ParentId
        {
            get;
            set;
        }
    
        /// <summary>
        /// Identifier of the loader associated with this frame.
        ///</summary>
        public string LoaderId
        {
            get;
            set;
        }
    
        /// <summary>
        /// Frame's name as specified in the tag.
        ///</summary>
        public string Name
        {
            get;
            set;
        }
    
        /// <summary>
        /// Frame document's URL.
        ///</summary>
        public string Url
        {
            get;
            set;
        }
    
        /// <summary>
        /// Frame document's security origin.
        ///</summary>
        public string SecurityOrigin
        {
            get;
            set;
        }
    
        /// <summary>
        /// Frame document's mimeType as determined by the browser.
        ///</summary>
        public string MimeType
        {
            get;
            set;
        }
    
    }
}