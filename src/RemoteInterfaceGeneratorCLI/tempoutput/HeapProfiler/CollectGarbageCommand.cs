namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class CollectGarbageCommand : ICommand<CollectGarbageCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "HeapProfiler.collectGarbage";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class CollectGarbageCommandResponse : ICommandResponse
    {
    
    }
}