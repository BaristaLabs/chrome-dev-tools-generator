namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables target discovery for the specified locations, when <code>setDiscoverTargets</code> was set to <code>true</code>.
    /// </summary>
    public sealed class SetRemoteLocationsCommand : ICommand<SetRemoteLocationsCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Target.setRemoteLocations";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// List of remote locations.
        /// </summary>
        
        [JsonProperty("locations")]
        public RemoteLocation[] Locations
        {
            get;
            set;
        }
    
    }

    public sealed class SetRemoteLocationsCommandResponse : ICommandResponse
    {
    
    }
}