namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets JavaScript breakpoint at a given location.
    /// </summary>
    public sealed class SetBreakpointCommand : ICommand<SetBreakpointCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.setBreakpoint";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Location to set breakpoint in.
        /// </summary>
        
        [JsonProperty("location")]
        public Location Location
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Expression to use as a breakpoint condition. When specified, debugger will only stop on the breakpoint if this expression evaluates to true.
        /// </summary>
        
        [JsonProperty("condition")]
        public string Condition
        {
            get;
            set;
        }
    
    }

    public sealed class SetBreakpointCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Id of the created breakpoint for further reference.
        ///</summary>
        
        [JsonProperty("breakpointId")]
        public string BreakpointId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Location this breakpoint resolved into.
        ///</summary>
        
        [JsonProperty("actualLocation")]
        public Location ActualLocation
        {
            get;
            set;
        }
    
    }
}