namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Tells whether emulation is supported.
    /// </summary>
    public sealed class CanEmulateCommand : ICommand<CanEmulateCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.canEmulate";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class CanEmulateCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// True if emulation is supported.
        ///</summary>
        
        [JsonProperty("result")]
        public bool Result
        {
            get;
            set;
        }
    
    }
}