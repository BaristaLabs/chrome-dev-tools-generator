namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    /// <summary>
    /// Specifies a number of samples attributed to a certain source position.
    /// </summary>
    public sealed class PositionTickInfo
    {
    
        /// <summary>
        /// Source line number (1-based).
        ///</summary>
        public long Line
        {
            get;
            set;
        }
    
        /// <summary>
        /// Number of samples attributed to the source line.
        ///</summary>
        public long Ticks
        {
            get;
            set;
        }
    
    }
}