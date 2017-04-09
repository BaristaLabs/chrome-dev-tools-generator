namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    /// <summary>
    /// Match data for a CSS rule.
    /// </summary>
    public sealed class RuleMatch
    {
    
        /// <summary>
        /// CSS rule in the match.
        ///</summary>
        public CSSRule Rule
        {
            get;
            set;
        }
    
        /// <summary>
        /// Matching selector indices in the rule's selectorList selectors (0-based).
        ///</summary>
        public long[] MatchingSelectors
        {
            get;
            set;
        }
    
    }
}