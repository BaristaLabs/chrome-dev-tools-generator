namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines pause on exceptions state. Can be set to stop on all exceptions, uncaught exceptions or no exceptions. Initial pause on exceptions state is <code>none</code>.
    /// </summary>
    public sealed class SetPauseOnExceptionsCommand : ICommand<SetPauseOnExceptionsCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.setPauseOnExceptions";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Pause on exceptions mode.
        /// </summary>
        
        [JsonProperty("state")]
        public string State
        {
            get;
            set;
        }
    
    }

    public sealed class SetPauseOnExceptionsCommandResponse : ICommandResponse
    {
    
    }
}