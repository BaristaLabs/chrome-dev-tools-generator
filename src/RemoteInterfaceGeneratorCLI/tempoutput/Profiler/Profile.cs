namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    /// <summary>
    /// Profile.
    /// </summary>
    public sealed class Profile
    {
    
        /// <summary>
        /// The list of profile nodes. First item is the root node.
        ///</summary>
        public ProfileNode[] Nodes
        {
            get;
            set;
        }
    
        /// <summary>
        /// Profiling start timestamp in microseconds.
        ///</summary>
        public double StartTime
        {
            get;
            set;
        }
    
        /// <summary>
        /// Profiling end timestamp in microseconds.
        ///</summary>
        public double EndTime
        {
            get;
            set;
        }
    
        /// <summary>
        /// Ids of samples top nodes.
        ///</summary>
        public long[] Samples
        {
            get;
            set;
        }
    
        /// <summary>
        /// Time intervals between adjacent samples in microseconds. The first delta is relative to the profile startTime.
        ///</summary>
        public long[] TimeDeltas
        {
            get;
            set;
        }
    
    }
}