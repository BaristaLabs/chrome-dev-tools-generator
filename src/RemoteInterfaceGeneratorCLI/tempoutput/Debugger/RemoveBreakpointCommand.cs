namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Removes JavaScript breakpoint.
    /// </summary>
    public sealed class RemoveBreakpointCommand : ICommand<RemoveBreakpointCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.removeBreakpoint";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Gets or sets the breakpointId
        /// </summary>
        
        [JsonProperty("breakpointId")]
        public string BreakpointId
        {
            get;
            set;
        }
    
    }

    public sealed class RemoveBreakpointCommandResponse : ICommandResponse
    {
    
    }
}