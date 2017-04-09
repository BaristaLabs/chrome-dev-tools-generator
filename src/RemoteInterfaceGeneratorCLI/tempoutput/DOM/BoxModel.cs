namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    /// <summary>
    /// Box model.
    /// </summary>
    public sealed class BoxModel
    {
    
        /// <summary>
        /// Content box
        ///</summary>
        public double[] Content
        {
            get;
            set;
        }
    
        /// <summary>
        /// Padding box
        ///</summary>
        public double[] Padding
        {
            get;
            set;
        }
    
        /// <summary>
        /// Border box
        ///</summary>
        public double[] Border
        {
            get;
            set;
        }
    
        /// <summary>
        /// Margin box
        ///</summary>
        public double[] Margin
        {
            get;
            set;
        }
    
        /// <summary>
        /// Node width
        ///</summary>
        public long Width
        {
            get;
            set;
        }
    
        /// <summary>
        /// Node height
        ///</summary>
        public long Height
        {
            get;
            set;
        }
    
        /// <summary>
        /// Shape outside coordinates
        ///</summary>
        public ShapeOutsideInfo ShapeOutside
        {
            get;
            set;
        }
    
    }
}