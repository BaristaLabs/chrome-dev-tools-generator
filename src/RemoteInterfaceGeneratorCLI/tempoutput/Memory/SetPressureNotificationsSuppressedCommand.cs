namespace BaristaLabs.ChromeDevTools.Runtime.Memory
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enable/disable suppressing memory pressure notifications in all processes.
    /// </summary>
    public sealed class SetPressureNotificationsSuppressedCommand : ICommand<SetPressureNotificationsSuppressedCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Memory.setPressureNotificationsSuppressed";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// If true, memory pressure notifications will be suppressed.
        /// </summary>
        
        [JsonProperty("suppressed")]
        public bool Suppressed
        {
            get;
            set;
        }
    
    }

    public sealed class SetPressureNotificationsSuppressedCommandResponse : ICommandResponse
    {
    
    }
}