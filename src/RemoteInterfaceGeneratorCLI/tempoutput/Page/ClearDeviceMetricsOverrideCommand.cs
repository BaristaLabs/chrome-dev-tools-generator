namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Clears the overriden device metrics.
    /// </summary>
    public sealed class ClearDeviceMetricsOverrideCommand : ICommand<ClearDeviceMetricsOverrideCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.clearDeviceMetricsOverride";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class ClearDeviceMetricsOverrideCommandResponse : ICommandResponse
    {
    
    }
}