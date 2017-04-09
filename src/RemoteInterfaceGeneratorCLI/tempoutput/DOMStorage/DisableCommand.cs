namespace BaristaLabs.ChromeDevTools.Runtime.DOMStorage
{
    using Newtonsoft.Json;

    /// <summary>
    /// Disables storage tracking, prevents storage events from being sent to the client.
    /// </summary>
    public sealed class DisableCommand : ICommand<DisableCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOMStorage.disable";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class DisableCommandResponse : ICommandResponse
    {
    
    }
}