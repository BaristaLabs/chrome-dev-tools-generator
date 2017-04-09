namespace BaristaLabs.ChromeDevTools.Runtime.DeviceOrientation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Overrides the Device Orientation.
    /// </summary>
    public sealed class SetDeviceOrientationOverrideCommand : ICommand<SetDeviceOrientationOverrideCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DeviceOrientation.setDeviceOrientationOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Mock alpha
        /// </summary>
        
        [JsonProperty("alpha")]
        public double Alpha
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Mock beta
        /// </summary>
        
        [JsonProperty("beta")]
        public double Beta
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Mock gamma
        /// </summary>
        
        [JsonProperty("gamma")]
        public double Gamma
        {
            get;
            set;
        }
    
    }

    public sealed class SetDeviceOrientationOverrideCommandResponse : ICommandResponse
    {
    
    }
}