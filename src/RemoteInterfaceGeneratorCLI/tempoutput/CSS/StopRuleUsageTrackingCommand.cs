namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// The list of rules with an indication of whether these were used
    /// </summary>
    public sealed class StopRuleUsageTrackingCommand : ICommand<StopRuleUsageTrackingCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.stopRuleUsageTracking";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class StopRuleUsageTrackingCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Gets or sets the ruleUsage
        /// </summary>
        
        [JsonProperty("ruleUsage")]
        public RuleUsage[] RuleUsage
        {
            get;
            set;
        }
    
    }
}