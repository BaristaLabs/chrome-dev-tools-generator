namespace BaristaLabs.ChromeDevTools.Runtime.Inspector
{
    using Newtonsoft.Json;

    /// <summary>
    /// Disables inspector domain notifications.
    /// </summary>
    public sealed class DisableCommand : ICommand<DisableCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Inspector.disable";
        
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