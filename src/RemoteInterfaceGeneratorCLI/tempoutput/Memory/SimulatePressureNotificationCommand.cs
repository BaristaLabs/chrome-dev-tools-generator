namespace BaristaLabs.ChromeDevTools.Runtime.Memory
{
    using Newtonsoft.Json;

    /// <summary>
    /// Simulate a memory pressure notification in all processes.
    /// </summary>
    public sealed class SimulatePressureNotificationCommand : ICommand<SimulatePressureNotificationCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Memory.simulatePressureNotification";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Memory pressure level of the notification.
        /// </summary>
        
        [JsonProperty("level")]
        public PressureLevel Level
        {
            get;
            set;
        }
    
    }

    public sealed class SimulatePressureNotificationCommandResponse : ICommandResponse
    {
    
    }
}