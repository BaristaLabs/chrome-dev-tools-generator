namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class StopCommand : ICommand<StopCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Profiler.stop";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class StopCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Recorded profile.
        ///</summary>
        
        [JsonProperty("profile")]
        public Profile Profile
        {
            get;
            set;
        }
    
    }
}