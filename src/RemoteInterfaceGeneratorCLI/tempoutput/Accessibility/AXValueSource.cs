namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    /// <summary>
    /// A single source for a computed AX property.
    /// </summary>
    public sealed class AXValueSource
    {
    
        /// <summary>
        /// What type of source this is.
        ///</summary>
        public AXValueSourceType Type
        {
            get;
            set;
        }
    
        /// <summary>
        /// The value of this property source.
        ///</summary>
        public AXValue Value
        {
            get;
            set;
        }
    
        /// <summary>
        /// The name of the relevant attribute, if any.
        ///</summary>
        public string Attribute
        {
            get;
            set;
        }
    
        /// <summary>
        /// The value of the relevant attribute, if any.
        ///</summary>
        public AXValue AttributeValue
        {
            get;
            set;
        }
    
        /// <summary>
        /// Whether this source is superseded by a higher priority source.
        ///</summary>
        public bool Superseded
        {
            get;
            set;
        }
    
        /// <summary>
        /// The native markup source for this value, e.g. a <label> element.
        ///</summary>
        public AXValueNativeSourceType NativeSource
        {
            get;
            set;
        }
    
        /// <summary>
        /// The value, such as a node or node list, of the native source.
        ///</summary>
        public AXValue NativeSourceValue
        {
            get;
            set;
        }
    
        /// <summary>
        /// Whether the value for this property is invalid.
        ///</summary>
        public bool Invalid
        {
            get;
            set;
        }
    
        /// <summary>
        /// Reason for the value being invalid, if it is.
        ///</summary>
        public string InvalidReason
        {
            get;
            set;
        }
    
    }
}