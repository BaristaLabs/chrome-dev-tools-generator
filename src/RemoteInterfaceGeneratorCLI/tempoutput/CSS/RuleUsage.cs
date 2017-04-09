namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    /// <summary>
    /// CSS rule usage information.
    /// </summary>
    public sealed class RuleUsage
    {
    
        /// <summary>
        /// The css style sheet identifier (absent for user agent stylesheet and user-specified stylesheet rules) this rule came from.
        ///</summary>
        public string StyleSheetId
        {
            get;
            set;
        }
    
        /// <summary>
        /// Style declaration range in the enclosing stylesheet (if available).
        ///</summary>
        public SourceRange Range
        {
            get;
            set;
        }
    
        /// <summary>
        /// Indicates whether the rule was actually used by some element in the page.
        ///</summary>
        public bool Used
        {
            get;
            set;
        }
    
    }
}