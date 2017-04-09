namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Turns on virtual time for all frames (replacing real-time with a synthetic time source) and sets the current virtual time policy.  Note this supersedes any previous time budget.
    /// </summary>
    public sealed class SetVirtualTimePolicyCommand : ICommand<SetVirtualTimePolicyCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setVirtualTimePolicy";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Gets or sets the policy
        /// </summary>
        
        [JsonProperty("policy")]
        public VirtualTimePolicy Policy
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// If set, after this many virtual milliseconds have elapsed virtual time will be paused and a virtualTimeBudgetExpired event is sent.
        /// </summary>
        
        [JsonProperty("budget")]
        public long Budget
        {
            get;
            set;
        }
    
    }

    public sealed class SetVirtualTimePolicyCommandResponse : ICommandResponse
    {
    
    }
}