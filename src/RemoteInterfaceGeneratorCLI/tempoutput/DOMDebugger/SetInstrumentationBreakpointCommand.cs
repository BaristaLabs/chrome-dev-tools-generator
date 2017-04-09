namespace BaristaLabs.ChromeDevTools.Runtime.DOMDebugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets breakpoint on particular native event.
    /// </summary>
    public sealed class SetInstrumentationBreakpointCommand : ICommand<SetInstrumentationBreakpointCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOMDebugger.setInstrumentationBreakpoint";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Instrumentation name to stop on.
        /// </summary>
        
        [JsonProperty("eventName")]
        public string EventName
        {
            get;
            set;
        }
    
    }

    public sealed class SetInstrumentationBreakpointCommandResponse : ICommandResponse
    {
    
    }
}