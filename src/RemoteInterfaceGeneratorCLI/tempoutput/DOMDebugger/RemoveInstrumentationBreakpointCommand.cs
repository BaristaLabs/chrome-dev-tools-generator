namespace BaristaLabs.ChromeDevTools.Runtime.DOMDebugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Removes breakpoint on particular native event.
    /// </summary>
    public sealed class RemoveInstrumentationBreakpointCommand : ICommand<RemoveInstrumentationBreakpointCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOMDebugger.removeInstrumentationBreakpoint";
        
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

    public sealed class RemoveInstrumentationBreakpointCommandResponse : ICommandResponse
    {
    
    }
}