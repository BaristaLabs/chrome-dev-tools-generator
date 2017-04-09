namespace BaristaLabs.ChromeDevTools.Runtime.DOMDebugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Removes breakpoint on particular DOM event.
    /// </summary>
    public sealed class RemoveEventListenerBreakpointCommand : ICommand<RemoveEventListenerBreakpointCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOMDebugger.removeEventListenerBreakpoint";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Event name.
        /// </summary>
        
        [JsonProperty("eventName")]
        public string EventName
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// EventTarget interface name.
        /// </summary>
        
        [JsonProperty("targetName")]
        public string TargetName
        {
            get;
            set;
        }
    
    }

    public sealed class RemoveEventListenerBreakpointCommandResponse : ICommandResponse
    {
    
    }
}