namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    /// <summary>
    /// A single computed AX property.
    /// </summary>
    public sealed class AXValue
    {
    
        /// <summary>
        /// The type of this value.
        ///</summary>
        public AXValueType Type
        {
            get;
            set;
        }
    
        /// <summary>
        /// The computed value of this property.
        ///</summary>
        public object Value
        {
            get;
            set;
        }
    
        /// <summary>
        /// One or more related nodes, if applicable.
        ///</summary>
        public AXRelatedNode[] RelatedNodes
        {
            get;
            set;
        }
    
        /// <summary>
        /// The sources which contributed to the computation of this property.
        ///</summary>
        public AXValueSource[] Sources
        {
            get;
            set;
        }
    
    }
}