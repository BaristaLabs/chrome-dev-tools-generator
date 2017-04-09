namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class StartCommand : ICommand<StartCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Profiler.start";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class StartCommandResponse : ICommandResponse
    {
    
    }
}