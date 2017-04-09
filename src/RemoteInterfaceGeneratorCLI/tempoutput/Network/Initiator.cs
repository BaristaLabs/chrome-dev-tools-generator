namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    /// <summary>
    /// Information about the request initiator.
    /// </summary>
    public sealed class Initiator
    {
    
        /// <summary>
        /// Type of this initiator.
        ///</summary>
        public string Type
        {
            get;
            set;
        }
    
        /// <summary>
        /// Initiator JavaScript stack trace, set for Script only.
        ///</summary>
        public BaristaLabs.ChromeDevTools.Runtime.Runtime.StackTrace Stack
        {
            get;
            set;
        }
    
        /// <summary>
        /// Initiator URL, set for Parser type only.
        ///</summary>
        public string Url
        {
            get;
            set;
        }
    
        /// <summary>
        /// Initiator line number, set for Parser type only (0-based).
        ///</summary>
        public double LineNumber
        {
            get;
            set;
        }
    
    }
}