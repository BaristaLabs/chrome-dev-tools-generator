namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class PropertyPreview
    {
    
        /// <summary>
        /// Property name.
        ///</summary>
        public string Name
        {
            get;
            set;
        }
    
        /// <summary>
        /// Object type. Accessor means that the property itself is an accessor property.
        ///</summary>
        public string Type
        {
            get;
            set;
        }
    
        /// <summary>
        /// User-friendly property value string.
        ///</summary>
        public string Value
        {
            get;
            set;
        }
    
        /// <summary>
        /// Nested value preview.
        ///</summary>
        public ObjectPreview ValuePreview
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
    
    }
}