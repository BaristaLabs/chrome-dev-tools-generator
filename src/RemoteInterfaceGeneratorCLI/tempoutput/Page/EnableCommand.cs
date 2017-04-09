namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables page domain notifications.
    /// </summary>
    public sealed class EnableCommand : ICommand<EnableCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.enable";
        
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