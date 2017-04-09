namespace BaristaLabs.ChromeDevTools.Runtime.LayerTree
{
    /// <summary>
    /// Information about a compositing layer.
    /// </summary>
    public sealed class Layer
    {
    
        /// <summary>
        /// The unique id for this layer.
        ///</summary>
        public string LayerId
        {
            get;
            set;
        }
    
        /// <summary>
        /// The id of parent (not present for root).
        ///</summary>
        public string ParentLayerId
        {
            get;
            set;
        }
    
        /// <summary>
        /// The backend id for the node associated with this layer.
        ///</summary>
        public long BackendNodeId
        {
            get;
            set;
        }
    
        /// <summary>
        /// Offset from parent layer, X coordinate.
        ///</summary>
        public double OffsetX
        {
            get;
            set;
        }
    
        /// <summary>
        /// Offset from parent layer, Y coordinate.
        ///</summary>
        public double OffsetY
        {
            get;
            set;
        }
    
        /// <summary>
        /// Layer width.
        ///</summary>
        public double Width
        {
            get;
            set;
        }
    
        /// <summary>
        /// Layer height.
        ///</summary>
        public double Height
        {
            get;
            set;
        }
    
        /// <summary>
        /// Transformation matrix for layer, default is identity matrix
        ///</summary>
        public double[] Transform
        {
            get;
            set;
        }
    
        /// <summary>
        /// Transform anchor point X, absent if no transform specified
        ///</summary>
        public double AnchorX
        {
            get;
            set;
        }
    
        /// <summary>
        /// Transform anchor point Y, absent if no transform specified
        ///</summary>
        public double AnchorY
        {
            get;
            set;
        }
    
        /// <summary>
        /// Transform anchor point Z, absent if no transform specified
        ///</summary>
        public double AnchorZ
        {
            get;
            set;
        }
    
        /// <summary>
        /// Indicates how many time this layer has painted.
        ///</summary>
        public long PaintCount
        {
            get;
            set;
        }
    
        /// <summary>
        /// Indicates whether this layer hosts any content, rather than being used for transform/scrolling purposes only.
        ///</summary>
        public bool DrawsContent
        {
            get;
            set;
        }
    
        /// <summary>
        /// Set if layer is not visible.
        ///</summary>
        public bool Invisible
        {
            get;
            set;
        }
    
        /// <summary>
        /// Rectangles scrolling on main thread only.
        ///</summary>
        public ScrollRect[] ScrollRects
        {
            get;
            set;
        }
    
    }
}