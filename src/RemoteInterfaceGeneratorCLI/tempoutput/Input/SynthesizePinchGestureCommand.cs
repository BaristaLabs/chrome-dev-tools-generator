namespace BaristaLabs.ChromeDevTools.Runtime.Input
{
    using Newtonsoft.Json;

    /// <summary>
    /// Synthesizes a pinch gesture over a time period by issuing appropriate touch events.
    /// </summary>
    public sealed class SynthesizePinchGestureCommand : ICommand<SynthesizePinchGestureCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Input.synthesizePinchGesture";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// X coordinate of the start of the gesture in CSS pixels.
        /// </summary>
        
        [JsonProperty("x")]
        public long X
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Y coordinate of the start of the gesture in CSS pixels.
        /// </summary>
        
        [JsonProperty("y")]
        public long Y
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Relative scale factor after zooming (>1.0 zooms in, <1.0 zooms out).
        /// </summary>
        
        [JsonProperty("scaleFactor")]
        public double ScaleFactor
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Relative pointer speed in pixels per second (default: 800).
        /// </summary>
        
        [JsonProperty("relativeSpeed")]
        public long RelativeSpeed
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Which type of input events to be generated (default: 'default', which queries the platform for the preferred input type).
        /// </summary>
        
        [JsonProperty("gestureSourceType")]
        public GestureSourceType GestureSourceType
        {
            get;
            set;
        }
    
    }

    public sealed class SynthesizePinchGestureCommandResponse : ICommandResponse
    {
    
    }
}