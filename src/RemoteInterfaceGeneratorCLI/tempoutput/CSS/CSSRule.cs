namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    /// <summary>
    /// CSS rule representation.
    /// </summary>
    public sealed class CSSRule
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
        /// Rule selector data.
        ///</summary>
        public SelectorList SelectorList
        {
            get;
            set;
        }
    
        /// <summary>
        /// Parent stylesheet's origin.
        ///</summary>
        public StyleSheetOrigin Origin
        {
            get;
            set;
        }
    
        /// <summary>
        /// Associated style declaration.
        ///</summary>
        public CSSStyle Style
        {
            get;
            set;
        }
    
        /// <summary>
        /// Media list array (for rules involving media queries). The array enumerates media queries starting with the innermost one, going outwards.
        ///</summary>
        public CSSMedia[] Media
        {
            get;
            set;
        }
    
    }
}