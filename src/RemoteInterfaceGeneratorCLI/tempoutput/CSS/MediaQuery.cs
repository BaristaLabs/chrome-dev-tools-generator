namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    /// <summary>
    /// Media query descriptor.
    /// </summary>
    public sealed class MediaQuery
    {
    
        /// <summary>
        /// Array of media query expressions.
        ///</summary>
        public MediaQueryExpression[] Expressions
        {
            get;
            set;
        }
    
        /// <summary>
        /// Whether the media query condition is satisfied.
        ///</summary>
        public bool Active
        {
            get;
            set;
        }
    
    }
}