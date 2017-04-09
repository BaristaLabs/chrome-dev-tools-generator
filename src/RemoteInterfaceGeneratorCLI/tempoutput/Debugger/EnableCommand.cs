namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables debugger for the given page. Clients should not assume that the debugging has been enabled until the result for this command is received.
    /// </summary>
    public sealed class EnableCommand : ICommand<EnableCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.enable";
        
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