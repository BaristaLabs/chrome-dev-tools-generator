namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    /// <summary>
    /// CSS stylesheet metainformation.
    /// </summary>
    public sealed class CSSStyleSheetHeader
    {
    
        /// <summary>
        /// The stylesheet identifier.
        ///</summary>
        public string StyleSheetId
        {
            get;
            set;
        }
    
        /// <summary>
        /// Owner frame identifier.
        ///</summary>
        public string FrameId
        {
            get;
            set;
        }
    
        /// <summary>
        /// Stylesheet resource URL.
        ///</summary>
        public string SourceURL
        {
            get;
            set;
        }
    
        /// <summary>
        /// URL of source map associated with the stylesheet (if any).
        ///</summary>
        public string SourceMapURL
        {
            get;
            set;
        }
    
        /// <summary>
        /// Stylesheet origin.
        ///</summary>
        public StyleSheetOrigin Origin
        {
            get;
            set;
        }
    
        /// <summary>
        /// Stylesheet title.
        ///</summary>
        public string Title
        {
            get;
            set;
        }
    
        /// <summary>
        /// The backend id for the owner node of the stylesheet.
        ///</summary>
        public long OwnerNode
        {
            get;
            set;
        }
    
        /// <summary>
        /// Denotes whether the stylesheet is disabled.
        ///</summary>
        public bool Disabled
        {
            get;
            set;
        }
    
        /// <summary>
        /// Whether the sourceURL field value comes from the sourceURL comment.
        ///</summary>
        public bool HasSourceURL
        {
            get;
            set;
        }
    
        /// <summary>
        /// Whether this stylesheet is created for STYLE tag by parser. This flag is not set for document.written STYLE tags.
        ///</summary>
        public bool IsInline
        {
            get;
            set;
        }
    
        /// <summary>
        /// Line offset of the stylesheet within the resource (zero based).
        ///</summary>
        public double StartLine
        {
            get;
            set;
        }
    
        /// <summary>
        /// Column offset of the stylesheet within the resource (zero based).
        ///</summary>
        public double StartColumn
        {
            get;
            set;
        }
    
    }
}