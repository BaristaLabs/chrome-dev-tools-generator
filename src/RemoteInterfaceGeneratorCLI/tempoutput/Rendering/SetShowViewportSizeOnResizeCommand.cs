namespace BaristaLabs.ChromeDevTools.Runtime.Rendering
{
    using Newtonsoft.Json;

    /// <summary>
    /// Paints viewport size upon main frame resize.
    /// </summary>
    public sealed class SetShowViewportSizeOnResizeCommand : ICommand<SetShowViewportSizeOnResizeCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Rendering.setShowViewportSizeOnResize";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Whether to paint size or not.
        /// </summary>
        
        [JsonProperty("show")]
        public bool Show
        {
            get;
            set;
        }
    
    }

    public sealed class SetShowViewportSizeOnResizeCommandResponse : ICommandResponse
    {
    
    }
}