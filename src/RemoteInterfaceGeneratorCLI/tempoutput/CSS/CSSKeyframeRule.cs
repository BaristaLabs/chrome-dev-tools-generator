namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    /// <summary>
    /// CSS keyframe rule representation.
    /// </summary>
    public sealed class CSSKeyframeRule
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
        /// Parent stylesheet's origin.
        ///</summary>
        public StyleSheetOrigin Origin
        {
            get;
            set;
        }
    
        /// <summary>
        /// Associated key text.
        ///</summary>
        public Value KeyText
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
    
    }
}