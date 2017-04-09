namespace BaristaLabs.ChromeDevTools.Runtime.Tracing
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class TraceConfig
    {
    
        /// <summary>
        /// Controls how the trace buffer stores data.
        ///</summary>
        public string RecordMode
        {
            get;
            set;
        }
    
        /// <summary>
        /// Turns on JavaScript stack sampling.
        ///</summary>
        public bool EnableSampling
        {
            get;
            set;
        }
    
        /// <summary>
        /// Turns on system tracing.
        ///</summary>
        public bool EnableSystrace
        {
            get;
            set;
        }
    
        /// <summary>
        /// Turns on argument filter.
        ///</summary>
        public bool EnableArgumentFilter
        {
            get;
            set;
        }
    
        /// <summary>
        /// Included category filters.
        ///</summary>
        public string[] IncludedCategories
        {
            get;
            set;
        }
    
        /// <summary>
        /// Excluded category filters.
        ///</summary>
        public string[] ExcludedCategories
        {
            get;
            set;
        }
    
        /// <summary>
        /// Configuration to synthesize the delays in tracing.
        ///</summary>
        public string[] SyntheticDelays
        {
            get;
            set;
        }
    
        /// <summary>
        /// Configuration for memory dump triggers. Used only when "memory-infra" category is enabled.
        ///</summary>
        public MemoryDumpConfig MemoryDumpConfig
        {
            get;
            set;
        }
    
    }
}