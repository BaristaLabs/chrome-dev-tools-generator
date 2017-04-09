namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    /// <summary>
    /// Data for a simple selector (these are delimited by commas in a selector list).
    /// </summary>
    public sealed class Value
    {
    
        /// <summary>
        /// Value text.
        ///</summary>
        public string Text
        {
            get;
            set;
        }
    
        /// <summary>
        /// Value range in the underlying resource (if available).
        ///</summary>
        public SourceRange Range
        {
            get;
            set;
        }
    
    }
}