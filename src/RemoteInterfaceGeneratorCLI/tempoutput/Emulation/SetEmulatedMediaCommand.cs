namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Emulates the given media for CSS media queries.
    /// </summary>
    public sealed class SetEmulatedMediaCommand : ICommand<SetEmulatedMediaCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setEmulatedMedia";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Media type to emulate. Empty string disables the override.
        /// </summary>
        
        [JsonProperty("media")]
        public string Media
        {
            get;
            set;
        }
    
    }

    public sealed class SetEmulatedMediaCommandResponse : ICommandResponse
    {
    
    }
}