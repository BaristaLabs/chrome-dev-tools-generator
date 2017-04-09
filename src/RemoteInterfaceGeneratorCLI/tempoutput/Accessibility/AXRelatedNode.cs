namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class AXRelatedNode
    {
    
        /// <summary>
        /// The BackendNodeId of the related DOM node.
        ///</summary>
        public long BackendDOMNodeId
        {
            get;
            set;
        }
    
        /// <summary>
        /// The IDRef value provided, if any.
        ///</summary>
        public string Idref
        {
            get;
            set;
        }
    
        /// <summary>
        /// The text alternative of this node in the current context.
        ///</summary>
        public string Text
        {
            get;
            set;
        }
    
    }
}