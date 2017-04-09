namespace BaristaLabs.ChromeDevTools.Runtime.IndexedDB
{
    /// <summary>
    /// Key.
    /// </summary>
    public sealed class Key
    {
    
        /// <summary>
        /// Key type.
        ///</summary>
        public string Type
        {
            get;
            set;
        }
    
        /// <summary>
        /// Number value.
        ///</summary>
        public double Number
        {
            get;
            set;
        }
    
        /// <summary>
        /// String value.
        ///</summary>
        public string String
        {
            get;
            set;
        }
    
        /// <summary>
        /// Date value.
        ///</summary>
        public double Date
        {
            get;
            set;
        }
    
        /// <summary>
        /// Array value.
        ///</summary>
        public Key[] Array
        {
            get;
            set;
        }
    
    }
}