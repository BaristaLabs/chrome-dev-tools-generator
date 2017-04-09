namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Clears the overriden Geolocation Position and Error.
    /// </summary>
    public sealed class ClearGeolocationOverrideCommand : ICommand<ClearGeolocationOverrideCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.clearGeolocationOverride";
        
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