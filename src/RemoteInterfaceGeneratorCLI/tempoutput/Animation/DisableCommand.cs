namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Disables animation domain notifications.
    /// </summary>
    public sealed class DisableCommand : ICommand<DisableCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Animation.disable";
        
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