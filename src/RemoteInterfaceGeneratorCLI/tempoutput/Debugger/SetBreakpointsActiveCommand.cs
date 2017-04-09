namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Activates / deactivates all breakpoints on the page.
    /// </summary>
    public sealed class SetBreakpointsActiveCommand : ICommand<SetBreakpointsActiveCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.setBreakpointsActive";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// New value for breakpoints active state.
        /// </summary>
        
        [JsonProperty("active")]
        public bool Active
        {
            get;
            set;
        }
    
    }

    public sealed class SetBreakpointsActiveCommandResponse : ICommandResponse
    {
    
    }
}