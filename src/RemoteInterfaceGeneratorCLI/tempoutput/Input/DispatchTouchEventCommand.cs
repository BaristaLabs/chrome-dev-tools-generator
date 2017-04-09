namespace BaristaLabs.ChromeDevTools.Runtime.Input
{
    using Newtonsoft.Json;

    /// <summary>
    /// Dispatches a touch event to the page.
    /// </summary>
    public sealed class DispatchTouchEventCommand : ICommand<DispatchTouchEventCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Input.dispatchTouchEvent";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Type of the touch event.
        /// </summary>
        
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Touch points.
        /// </summary>
        
        [JsonProperty("touchPoints")]
        public TouchPoint[] TouchPoints
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Bit field representing pressed modifier keys. Alt=1, Ctrl=2, Meta/Command=4, Shift=8 (default: 0).
        /// </summary>
        
        [JsonProperty("modifiers")]
        public long Modifiers
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Time at which the event occurred. Measured in UTC time in seconds since January 1, 1970 (default: current time).
        /// </summary>
        
        [JsonProperty("timestamp")]
        public double Timestamp
        {
            get;
            set;
        }
    
    }

    public sealed class DispatchTouchEventCommandResponse : ICommandResponse
    {
    
    }
}