namespace BaristaLabs.ChromeDevTools.Runtime.Input
{
    using Newtonsoft.Json;

    /// <summary>
    /// Dispatches a mouse event to the page.
    /// </summary>
    public sealed class DispatchMouseEventCommand : ICommand<DispatchMouseEventCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Input.dispatchMouseEvent";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Type of the mouse event.
        /// </summary>
        
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// X coordinate of the event relative to the main frame's viewport.
        /// </summary>
        
        [JsonProperty("x")]
        public long X
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Y coordinate of the event relative to the main frame's viewport. 0 refers to the top of the viewport and Y increases as it proceeds towards the bottom of the viewport.
        /// </summary>
        
        [JsonProperty("y")]
        public long Y
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
    
        
        /// <summary>
        /// Mouse button (default: "none").
        /// </summary>
        
        [JsonProperty("button")]
        public string Button
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Number of times the mouse button was clicked (default: 0).
        /// </summary>
        
        [JsonProperty("clickCount")]
        public long ClickCount
        {
            get;
            set;
        }
    
    }

    public sealed class DispatchMouseEventCommandResponse : ICommandResponse
    {
    
    }
}