namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    /// <summary>
    /// Details of an element in the DOM tree with a LayoutObject.
    /// </summary>
    public sealed class LayoutTreeNode
    {
    
        /// <summary>
        /// The id of the related DOM node matching one from DOM.GetDocument.
        ///</summary>
        public long NodeId
        {
            get;
            set;
        }
    
        /// <summary>
        /// The absolute position bounding box.
        ///</summary>
        public BaristaLabs.ChromeDevTools.Runtime.DOM.Rect BoundingBox
        {
            get;
            set;
        }
    
        /// <summary>
        /// Contents of the LayoutText if any
        ///</summary>
        public string LayoutText
        {
            get;
            set;
        }
    
        /// <summary>
        /// The post layout inline text nodes, if any.
        ///</summary>
        public InlineTextBox[] InlineTextNodes
        {
            get;
            set;
        }
    
        /// <summary>
        /// Index into the computedStyles array returned by getLayoutTreeAndStyles.
        ///</summary>
        public long StyleIndex
        {
            get;
            set;
        }
    
    }
}