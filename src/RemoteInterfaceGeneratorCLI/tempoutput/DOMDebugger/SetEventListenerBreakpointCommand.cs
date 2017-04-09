namespace BaristaLabs.ChromeDevTools.Runtime.DOMDebugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets breakpoint on particular DOM event.
    /// </summary>
    public sealed class SetEventListenerBreakpointCommand : ICommand<SetEventListenerBreakpointCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOMDebugger.setEventListenerBreakpoint";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// DOM Event name to stop on (any DOM event will do).
        /// </summary>
        
        [JsonProperty("eventName")]
        public string EventName
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// EventTarget interface name to stop on. If equal to <code>"*"</code> or not provided, will stop on any EventTarget.
        /// </summary>
        
        [JsonProperty("targetName")]
        public string TargetName
        {
            get;
            set;
        }
    
    }

    public sealed class SetEventListenerBreakpointCommandResponse : ICommandResponse
    {
    
    }
}