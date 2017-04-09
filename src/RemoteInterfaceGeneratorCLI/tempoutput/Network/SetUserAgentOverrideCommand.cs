namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Allows overriding user agent with the given string.
    /// </summary>
    public sealed class SetUserAgentOverrideCommand : ICommand<SetUserAgentOverrideCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Network.setUserAgentOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// User agent to use.
        /// </summary>
        
        [JsonProperty("userAgent")]
        public string UserAgent
        {
            get;
            set;
        }
    
    }

    public sealed class SetUserAgentOverrideCommandResponse : ICommandResponse
    {
    
    }
}