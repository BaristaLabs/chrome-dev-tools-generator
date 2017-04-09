namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class StopSamplingCommand : ICommand<StopSamplingCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "HeapProfiler.stopSampling";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class StopSamplingCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Recorded sampling heap profile.
        ///</summary>
        
        [JsonProperty("profile")]
        public SamplingHeapProfile Profile
        {
            get;
            set;
        }
    
    }
}