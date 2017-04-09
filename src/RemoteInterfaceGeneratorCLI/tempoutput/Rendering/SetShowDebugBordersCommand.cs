namespace BaristaLabs.ChromeDevTools.Runtime.Rendering
{
    using Newtonsoft.Json;

    /// <summary>
    /// Requests that backend shows debug borders on layers
    /// </summary>
    public sealed class SetShowDebugBordersCommand : ICommand<SetShowDebugBordersCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Rendering.setShowDebugBorders";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// True for showing debug borders
        /// </summary>
        
        [JsonProperty("show")]
        public bool Show
        {
            get;
            set;
        }
    
    }

    public sealed class SetShowDebugBordersCommandResponse : ICommandResponse
    {
    
    }
}