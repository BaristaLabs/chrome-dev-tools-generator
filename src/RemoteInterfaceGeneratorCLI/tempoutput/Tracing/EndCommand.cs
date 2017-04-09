namespace BaristaLabs.ChromeDevTools.Runtime.Tracing
{
    using Newtonsoft.Json;

    /// <summary>
    /// Stop trace events collection.
    /// </summary>
    public sealed class EndCommand : ICommand<EndCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Tracing.end";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class EndCommandResponse : ICommandResponse
    {
    
    }
}