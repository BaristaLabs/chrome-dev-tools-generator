namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    /// <summary>
    /// A node in the accessibility tree.
    /// </summary>
    public sealed class AXNode
    {
    
        /// <summary>
        /// Unique identifier for this node.
        ///</summary>
        public string NodeId
        {
            get;
            set;
        }
    
        /// <summary>
        /// Whether this node is ignored for accessibility
        ///</summary>
        public bool Ignored
        {
            get;
            set;
        }
    
        /// <summary>
        /// Collection of reasons why this node is hidden.
        ///</summary>
        public AXProperty[] IgnoredReasons
        {
            get;
            set;
        }
    
        /// <summary>
        /// This <code>Node</code>'s role, whether explicit or implicit.
        ///</summary>
        public AXValue Role
        {
            get;
            set;
        }
    
        /// <summary>
        /// The accessible name for this <code>Node</code>.
        ///</summary>
        public AXValue Name
        {
            get;
            set;
        }
    
        /// <summary>
        /// The accessible description for this <code>Node</code>.
        ///</summary>
        public AXValue Description
        {
            get;
            set;
        }
    
        /// <summary>
        /// The value for this <code>Node</code>.
        ///</summary>
        public AXValue Value
        {
            get;
            set;
        }
    
        /// <summary>
        /// All other properties
        ///</summary>
        public AXProperty[] Properties
        {
            get;
            set;
        }
    
        /// <summary>
        /// IDs for each of this node's child nodes.
        ///</summary>
        public string[] ChildIds
        {
            get;
            set;
        }
    
        /// <summary>
        /// The backend ID for the associated DOM node, if any.
        ///</summary>
        public long BackendDOMNodeId
        {
            get;
            set;
        }
    
    }
}