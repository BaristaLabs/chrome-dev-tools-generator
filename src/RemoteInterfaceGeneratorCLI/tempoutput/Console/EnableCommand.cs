namespace BaristaLabs.ChromeDevTools.Runtime.Console
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables console domain, sends the messages collected so far to the client by means of the <code>messageAdded</code> notification.
    /// </summary>
    public sealed class EnableCommand : ICommand<EnableCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Console.enable";
        
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