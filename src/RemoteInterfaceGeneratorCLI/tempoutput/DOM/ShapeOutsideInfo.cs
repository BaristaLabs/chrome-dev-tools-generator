namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    /// <summary>
    /// CSS Shape Outside details.
    /// </summary>
    public sealed class ShapeOutsideInfo
    {
    
        /// <summary>
        /// Shape bounds
        ///</summary>
        public double[] Bounds
        {
            get;
            set;
        }
    
        /// <summary>
        /// Shape coordinate details
        ///</summary>
        public object[] Shape
        {
            get;
            set;
        }
    
        /// <summary>
        /// Margin shape bounds
        ///</summary>
        public object[] MarginShape
        {
            get;
            set;
        }
    
    }
}