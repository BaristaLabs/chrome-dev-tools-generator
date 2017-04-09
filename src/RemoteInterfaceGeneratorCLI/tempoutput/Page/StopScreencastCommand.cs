namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Stops sending each frame in the <code>screencastFrame</code>.
    /// </summary>
    public sealed class StopScreencastCommand : ICommand<StopScreencastCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.stopScreencast";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class StopScreencastCommandResponse : ICommandResponse
    {
    
    }
}