namespace BaristaLabs.ChromeDevTools.Runtime.DOMDebugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Removes DOM breakpoint that was set using <code>setDOMBreakpoint</code>.
    /// </summary>
    public sealed class RemoveDOMBreakpointCommand : ICommand<RemoveDOMBreakpointCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOMDebugger.removeDOMBreakpoint";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Identifier of the node to remove breakpoint from.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Type of the breakpoint to remove.
        /// </summary>
        
        [JsonProperty("type")]
        public DOMBreakpointType Type
        {
            get;
            set;
        }
    
    }

    public sealed class RemoveDOMBreakpointCommandResponse : ICommandResponse
    {
    
    }
}