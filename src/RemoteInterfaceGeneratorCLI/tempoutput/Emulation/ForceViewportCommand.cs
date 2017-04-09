namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Overrides the visible area of the page. The change is hidden from the page, i.e. the observable scroll position and page scale does not change. In effect, the command moves the specified area of the page into the top-left corner of the frame.
    /// </summary>
    public sealed class ForceViewportCommand : ICommand<ForceViewportCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Emulation.forceViewport";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// X coordinate of top-left corner of the area (CSS pixels).
        /// </summary>
        
        [JsonProperty("x")]
        public double X
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Y coordinate of top-left corner of the area (CSS pixels).
        /// </summary>
        
        [JsonProperty("y")]
        public double Y
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Scale to apply to the area (relative to a page scale of 1.0).
        /// </summary>
        
        [JsonProperty("scale")]
        public double Scale
        {
            get;
            set;
        }
    
    }

    public sealed class ForceViewportCommandResponse : ICommandResponse
    {
    
    }
}