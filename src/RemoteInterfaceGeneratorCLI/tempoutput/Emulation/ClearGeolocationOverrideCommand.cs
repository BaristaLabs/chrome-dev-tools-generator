namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Clears the overriden Geolocation Position and Error.
    /// </summary>
    public sealed class ClearGeolocationOverrideCommand : ICommand<ClearGeolocationOverrideCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.clearGeolocationOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class ClearGeolocationOverrideCommandResponse : ICommandResponse
    {
    
    }
}