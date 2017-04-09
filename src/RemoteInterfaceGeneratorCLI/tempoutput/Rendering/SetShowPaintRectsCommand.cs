namespace BaristaLabs.ChromeDevTools.Runtime.Rendering
{
    using Newtonsoft.Json;

    /// <summary>
    /// Requests that backend shows paint rectangles
    /// </summary>
    public sealed class SetShowPaintRectsCommand : ICommand<SetShowPaintRectsCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Rendering.setShowPaintRects";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// True for showing paint rectangles
        /// </summary>
        
        [JsonProperty("result")]
        public bool Result
        {
            get;
            set;
        }
    
    }

    public sealed class SetShowPaintRectsCommandResponse : ICommandResponse
    {
    
    }
}