namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Controls whether to automatically attach to new targets which are considered to be related to this one. When turned on, attaches to all existing related targets as well. When turned off, automatically detaches from all currently attached targets.
    /// </summary>
    public sealed class SetAutoAttachCommand : ICommand<SetAutoAttachCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Target.setAutoAttach";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Whether to auto-attach to related targets.
        /// </summary>
        
        [JsonProperty("autoAttach")]
        public bool AutoAttach
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Whether to pause new targets when attaching to them. Use <code>Runtime.runIfWaitingForDebugger</code> to run paused targets.
        /// </summary>
        
        [JsonProperty("waitForDebuggerOnStart")]
        public bool WaitForDebuggerOnStart
        {
            get;
            set;
        }
    
    }

    public sealed class SetAutoAttachCommandResponse : ICommandResponse
    {
    
    }
}