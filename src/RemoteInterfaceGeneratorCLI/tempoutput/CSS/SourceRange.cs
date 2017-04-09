namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    /// <summary>
    /// Text range within a resource. All numbers are zero-based.
    /// </summary>
    public sealed class SourceRange
    {
    
        /// <summary>
        /// Start line of range.
        ///</summary>
        public long StartLine
        {
            get;
            set;
        }
    
        /// <summary>
        /// Start column of range (inclusive).
        ///</summary>
        public long StartColumn
        {
            get;
            set;
        }
    
        /// <summary>
        /// End line of range
        ///</summary>
        public long EndLine
        {
            get;
            set;
        }
    
        /// <summary>
        /// End column of range (exclusive).
        ///</summary>
        public long EndColumn
        {
            get;
            set;
        }
    
    }
}