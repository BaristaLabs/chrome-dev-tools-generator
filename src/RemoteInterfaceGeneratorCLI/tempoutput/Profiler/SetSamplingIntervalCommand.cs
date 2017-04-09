namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// Changes CPU profiler sampling interval. Must be called before CPU profiles recording started.
    /// </summary>
    public sealed class SetSamplingIntervalCommand : ICommand<SetSamplingIntervalCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Profiler.setSamplingInterval";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// New sampling interval in microseconds.
        /// </summary>
        
        [JsonProperty("interval")]
        public long Interval
        {
            get;
            set;
        }
    
    }

    public sealed class SetSamplingIntervalCommandResponse : ICommandResponse
    {
    
    }
}