namespace BaristaLabs.ChromeDevTools.Runtime.DOMDebugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets breakpoint on particular operation with DOM.
    /// </summary>
    public sealed class SetDOMBreakpointCommand : ICommand<SetDOMBreakpointCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOMDebugger.setDOMBreakpoint";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Identifier of the node to set breakpoint on.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Type of the operation to stop upon.
        /// </summary>
        
        [JsonProperty("type")]
        public DOMBreakpointType Type
        {
            get;
            set;
        }
    
    }

    public sealed class SetDOMBreakpointCommandResponse : ICommandResponse
    {
    
    }
}