namespace BaristaLabs.ChromeDevTools.Runtime.ApplicationCache
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables application cache domain notifications.
    /// </summary>
    public sealed class EnableCommand : ICommand<EnableCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "ApplicationCache.enable";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class EnableCommandResponse : ICommandResponse
    {
    
    }
}