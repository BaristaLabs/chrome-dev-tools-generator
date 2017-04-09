namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class SetCustomObjectFormatterEnabledCommand : ICommand<SetCustomObjectFormatterEnabledCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Runtime.setCustomObjectFormatterEnabled";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Gets or sets the enabled
        /// </summary>
        
        [JsonProperty("enabled")]
        public bool Enabled
        {
            get;
            set;
        }
    
    }

    public sealed class SetCustomObjectFormatterEnabledCommandResponse : ICommandResponse
    {
    
    }
}