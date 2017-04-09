namespace BaristaLabs.ChromeDevTools.Runtime.Input
{
    using Newtonsoft.Json;

    /// <summary>
    /// Synthesizes a tap gesture over a time period by issuing appropriate touch events.
    /// </summary>
    public sealed class SynthesizeTapGestureCommand : ICommand<SynthesizeTapGestureCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Input.synthesizeTapGesture";
        
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
        /// Duration between touchdown and touchup events in ms (default: 50).
        /// </summary>
        
        [JsonProperty("duration")]
        public long Duration
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Number of times to perform the tap (e.g. 2 for double tap, default: 1).
        /// </summary>
        
        [JsonProperty("tapCount")]
        public long TapCount
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

    public sealed class SynthesizeTapGestureCommandResponse : ICommandResponse
    {
    
    }
}