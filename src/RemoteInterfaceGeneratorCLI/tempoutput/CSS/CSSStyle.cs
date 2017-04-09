namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    /// <summary>
    /// CSS style representation.
    /// </summary>
    public sealed class CSSStyle
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
        /// CSS properties in the style.
        ///</summary>
        public CSSProperty[] CssProperties
        {
            get;
            set;
        }
    
        /// <summary>
        /// Computed values for all shorthands found in the style.
        ///</summary>
        public ShorthandEntry[] ShorthandEntries
        {
            get;
            set;
        }
    
        /// <summary>
        /// Style declaration text (if available).
        ///</summary>
        public string CssText
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
    
    }
}