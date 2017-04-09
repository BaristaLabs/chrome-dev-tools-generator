namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables the selector recording.
    /// </summary>
    public sealed class StartRuleUsageTrackingCommand : ICommand<StartRuleUsageTrackingCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.startRuleUsageTracking";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class StartRuleUsageTrackingCommandResponse : ICommandResponse
    {
    
    }
}