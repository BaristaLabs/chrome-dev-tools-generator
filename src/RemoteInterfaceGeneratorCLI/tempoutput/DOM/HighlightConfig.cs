namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    /// <summary>
    /// Configuration data for the highlighting of page elements.
    /// </summary>
    public sealed class HighlightConfig
    {
    
        /// <summary>
        /// Whether the node info tooltip should be shown (default: false).
        ///</summary>
        public bool ShowInfo
        {
            get;
            set;
        }
    
        /// <summary>
        /// Whether the rulers should be shown (default: false).
        ///</summary>
        public bool ShowRulers
        {
            get;
            set;
        }
    
        /// <summary>
        /// Whether the extension lines from node to the rulers should be shown (default: false).
        ///</summary>
        public bool ShowExtensionLines
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        public bool DisplayAsMaterial
        {
            get;
            set;
        }
    
        /// <summary>
        /// The content box highlight fill color (default: transparent).
        ///</summary>
        public RGBA ContentColor
        {
            get;
            set;
        }
    
        /// <summary>
        /// The padding highlight fill color (default: transparent).
        ///</summary>
        public RGBA PaddingColor
        {
            get;
            set;
        }
    
        /// <summary>
        /// The border highlight fill color (default: transparent).
        ///</summary>
        public RGBA BorderColor
        {
            get;
            set;
        }
    
        /// <summary>
        /// The margin highlight fill color (default: transparent).
        ///</summary>
        public RGBA MarginColor
        {
            get;
            set;
        }
    
        /// <summary>
        /// The event target element highlight fill color (default: transparent).
        ///</summary>
        public RGBA EventTargetColor
        {
            get;
            set;
        }
    
        /// <summary>
        /// The shape outside fill color (default: transparent).
        ///</summary>
        public RGBA ShapeColor
        {
            get;
            set;
        }
    
        /// <summary>
        /// The shape margin fill color (default: transparent).
        ///</summary>
        public RGBA ShapeMarginColor
        {
            get;
            set;
        }
    
        /// <summary>
        /// Selectors to highlight relevant nodes.
        ///</summary>
        public string SelectorList
        {
            get;
            set;
        }
    
    }
}