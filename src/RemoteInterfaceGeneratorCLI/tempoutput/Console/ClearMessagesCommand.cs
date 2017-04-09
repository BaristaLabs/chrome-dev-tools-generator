namespace BaristaLabs.ChromeDevTools.Runtime.Console
{
    using Newtonsoft.Json;

    /// <summary>
    /// Does nothing.
    /// </summary>
    public sealed class ClearMessagesCommand : ICommand<ClearMessagesCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Console.clearMessages";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class ClearMessagesCommandResponse : ICommandResponse
    {
    
    }
}