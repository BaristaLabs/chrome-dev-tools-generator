namespace BaristaLabs.ChromeDevTools.Runtime.DOMDebugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Removes breakpoint from XMLHttpRequest.
    /// </summary>
    public sealed class RemoveXHRBreakpointCommand : ICommand<RemoveXHRBreakpointCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOMDebugger.removeXHRBreakpoint";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Resource URL substring.
        /// </summary>
        
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }
    
    }

    public sealed class RemoveXHRBreakpointCommandResponse : ICommandResponse
    {
    
    }
}