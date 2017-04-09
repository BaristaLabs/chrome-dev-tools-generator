namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Toggles mouse event-based touch event emulation.
    /// </summary>
    public sealed class SetTouchEmulationEnabledCommand : ICommand<SetTouchEmulationEnabledCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setTouchEmulationEnabled";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Whether the touch event emulation should be enabled.
        /// </summary>
        
        [JsonProperty("enabled")]
        public bool Enabled
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Touch/gesture events configuration. Default: current platform.
        /// </summary>
        
        [JsonProperty("configuration")]
        public string Configuration
        {
            get;
            set;
        }
    
    }

    public sealed class SetTouchEmulationEnabledCommandResponse : ICommandResponse
    {
    
    }
}