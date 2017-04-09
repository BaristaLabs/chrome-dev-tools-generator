namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    /// <summary>
    /// Key range.
    /// </summary>
    public sealed class KeyRange
    {
    
        /// <summary>
        /// Lower bound.
        ///</summary>
        public Key Lower
        {
            get;
            set;
        }
    
        /// <summary>
        /// Upper bound.
        ///</summary>
        public Key Upper
        {
            get;
            set;
        }
    
        /// <summary>
        /// If true lower bound is open.
        ///</summary>
        public bool LowerOpen
        {
            get;
            set;
        }
    
        /// <summary>
        /// If true upper bound is open.
        ///</summary>
        public bool UpperOpen
        {
            get;
            set;
        }
    
    }
}