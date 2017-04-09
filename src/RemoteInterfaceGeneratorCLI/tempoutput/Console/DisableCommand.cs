namespace BaristaLabs.ChromeDevTools.Runtime.Console
{
    using Newtonsoft.Json;

    /// <summary>
    /// Disables console domain, prevents further console messages from being reported to the client.
    /// </summary>
    public sealed class DisableCommand : ICommand<DisableCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Console.disable";
        
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