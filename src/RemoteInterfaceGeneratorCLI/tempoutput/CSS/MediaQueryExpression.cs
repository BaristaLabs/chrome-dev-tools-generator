namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    /// <summary>
    /// Media query expression descriptor.
    /// </summary>
    public sealed class MediaQueryExpression
    {
    
        /// <summary>
        /// Media query expression value.
        ///</summary>
        public double Value
        {
            get;
            set;
        }
    
        /// <summary>
        /// Media query expression units.
        ///</summary>
        public string Unit
        {
            get;
            set;
        }
    
        /// <summary>
        /// Media query expression feature.
        ///</summary>
        public string Feature
        {
            get;
            set;
        }
    
        /// <summary>
        /// The associated range of the value text in the enclosing stylesheet (if available).
        ///</summary>
        public SourceRange ValueRange
        {
            get;
            set;
        }
    
        /// <summary>
        /// Computed length of media query expression (if applicable).
        ///</summary>
        public double ComputedLength
        {
            get;
            set;
        }
    
    }
}