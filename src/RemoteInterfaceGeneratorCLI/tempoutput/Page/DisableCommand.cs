namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Disables page domain notifications.
    /// </summary>
    public sealed class DisableCommand : ICommand<DisableCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.disable";
        
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