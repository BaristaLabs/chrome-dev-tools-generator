namespace BaristaLabs.ChromeDevTools.Runtime.DeviceOrientation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Clears the overridden Device Orientation.
    /// </summary>
    public sealed class ClearDeviceOrientationOverrideCommand : ICommand<ClearDeviceOrientationOverrideCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DeviceOrientation.clearDeviceOrientationOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class ClearDeviceOrientationOverrideCommandResponse : ICommandResponse
    {
    
    }
}