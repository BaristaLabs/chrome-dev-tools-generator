namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Stops on the next JavaScript statement.
    /// </summary>
    public sealed class PauseCommand : ICommand<PauseCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.pause";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class PauseCommandResponse : ICommandResponse
    {
    
    }
}