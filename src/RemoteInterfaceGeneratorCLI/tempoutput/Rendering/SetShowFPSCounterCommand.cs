namespace BaristaLabs.ChromeDevTools.Runtime.Rendering
{
    using Newtonsoft.Json;

    /// <summary>
    /// Requests that backend shows the FPS counter
    /// </summary>
    public sealed class SetShowFPSCounterCommand : ICommand<SetShowFPSCounterCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Rendering.setShowFPSCounter";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// True for showing the FPS counter
        /// </summary>
        
        [JsonProperty("show")]
        public bool Show
        {
            get;
            set;
        }
    
    }

    public sealed class SetShowFPSCounterCommandResponse : ICommandResponse
    {
    
    }
}