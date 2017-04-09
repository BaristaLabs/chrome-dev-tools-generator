namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Controls whether to discover available targets and notify via <code>targetCreated/targetDestroyed</code> events.
    /// </summary>
    public sealed class SetDiscoverTargetsCommand : ICommand<SetDiscoverTargetsCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Target.setDiscoverTargets";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Whether to discover available targets.
        /// </summary>
        
        [JsonProperty("discover")]
        public bool Discover
        {
            get;
            set;
        }
    
    }

    public sealed class SetDiscoverTargetsCommandResponse : ICommandResponse
    {
    
    }
}