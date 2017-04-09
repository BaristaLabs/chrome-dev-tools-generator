namespace BaristaLabs.ChromeDevTools.Runtime.Input
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class TouchPoint
    {
    
        /// <summary>
        /// State of the touch point.
        ///</summary>
        public string State
        {
            get;
            set;
        }
    
        /// <summary>
        /// X coordinate of the event relative to the main frame's viewport.
        ///</summary>
        public long X
        {
            get;
            set;
        }
    
        /// <summary>
        /// Y coordinate of the event relative to the main frame's viewport. 0 refers to the top of the viewport and Y increases as it proceeds towards the bottom of the viewport.
        ///</summary>
        public long Y
        {
            get;
            set;
        }
    
        /// <summary>
        /// X radius of the touch area (default: 1).
        ///</summary>
        public long RadiusX
        {
            get;
            set;
        }
    
        /// <summary>
        /// Y radius of the touch area (default: 1).
        ///</summary>
        public long RadiusY
        {
            get;
            set;
        }
    
        /// <summary>
        /// Rotation angle (default: 0.0).
        ///</summary>
        public double RotationAngle
        {
            get;
            set;
        }
    
        /// <summary>
        /// Force (default: 1.0).
        ///</summary>
        public double Force
        {
            get;
            set;
        }
    
        /// <summary>
        /// Identifier used to track touch sources between events, must be unique within an event.
        ///</summary>
        public double Id
        {
            get;
            set;
        }
    
    }
}