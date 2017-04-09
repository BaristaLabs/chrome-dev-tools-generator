namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Makes page not interrupt on any pauses (breakpoint, exception, dom exception etc).
    /// </summary>
    public sealed class SetSkipAllPausesCommand : ICommand<SetSkipAllPausesCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.setSkipAllPauses";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// New value for skip pauses state.
        /// </summary>
        
        [JsonProperty("skip")]
        public bool Skip
        {
            get;
            set;
        }
    
    }

    public sealed class SetSkipAllPausesCommandResponse : ICommandResponse
    {
    
    }
}