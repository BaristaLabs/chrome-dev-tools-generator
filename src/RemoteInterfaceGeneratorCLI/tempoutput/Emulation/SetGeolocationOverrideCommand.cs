namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Overrides the Geolocation Position or Error. Omitting any of the parameters emulates position unavailable.
    /// </summary>
    public sealed class SetGeolocationOverrideCommand : ICommand<SetGeolocationOverrideCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.setGeolocationOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Mock latitude
        /// </summary>
        
        [JsonProperty("latitude")]
        public double Latitude
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Mock longitude
        /// </summary>
        
        [JsonProperty("longitude")]
        public double Longitude
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Mock accuracy
        /// </summary>
        
        [JsonProperty("accuracy")]
        public double Accuracy
        {
            get;
            set;
        }
    
    }

    public sealed class SetGeolocationOverrideCommandResponse : ICommandResponse
    {
    
    }
}