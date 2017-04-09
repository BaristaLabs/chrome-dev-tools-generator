namespace BaristaLabs.ChromeDevTools.Runtime.Security
{
    /// <summary>
    /// Information about insecure content on the page.
    /// </summary>
    public sealed class InsecureContentStatus
    {
    
        /// <summary>
        /// True if the page was loaded over HTTPS and ran mixed (HTTP) content such as scripts.
        ///</summary>
        public bool RanMixedContent
        {
            get;
            set;
        }
    
        /// <summary>
        /// True if the page was loaded over HTTPS and displayed mixed (HTTP) content such as images.
        ///</summary>
        public bool DisplayedMixedContent
        {
            get;
            set;
        }
    
        /// <summary>
        /// True if the page was loaded over HTTPS without certificate errors, and ran content such as scripts that were loaded with certificate errors.
        ///</summary>
        public bool RanContentWithCertErrors
        {
            get;
            set;
        }
    
        /// <summary>
        /// True if the page was loaded over HTTPS without certificate errors, and displayed content such as images that were loaded with certificate errors.
        ///</summary>
        public bool DisplayedContentWithCertErrors
        {
            get;
            set;
        }
    
        /// <summary>
        /// Security state representing a page that ran insecure content.
        ///</summary>
        public SecurityState RanInsecureContentStyle
        {
            get;
            set;
        }
    
        /// <summary>
        /// Security state representing a page that displayed insecure content.
        ///</summary>
        public SecurityState DisplayedInsecureContentStyle
        {
            get;
            set;
        }
    
    }
}