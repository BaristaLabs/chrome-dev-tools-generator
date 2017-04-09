namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    /// <summary>
    /// Object containing abbreviated remote object value.
    /// </summary>
    public sealed class ObjectPreview
    {
    
        /// <summary>
        /// Object type.
        ///</summary>
        public string Type
        {
            get;
            set;
        }
    
        /// <summary>
        /// Object subtype hint. Specified for <code>object</code> type values only.
        ///</summary>
        public string Subtype
        {
            get;
            set;
        }
    
        /// <summary>
        /// String representation of the object.
        ///</summary>
        public string Description
        {
            get;
            set;
        }
    
        /// <summary>
        /// True iff some of the properties or entries of the original object did not fit.
        ///</summary>
        public bool Overflow
        {
            get;
            set;
        }
    
        /// <summary>
        /// List of the properties.
        ///</summary>
        public PropertyPreview[] Properties
        {
            get;
            set;
        }
    
        /// <summary>
        /// List of the entries. Specified for <code>map</code> and <code>set</code> subtype values only.
        ///</summary>
        public EntryPreview[] Entries
        {
            get;
            set;
        }
    
    }
}