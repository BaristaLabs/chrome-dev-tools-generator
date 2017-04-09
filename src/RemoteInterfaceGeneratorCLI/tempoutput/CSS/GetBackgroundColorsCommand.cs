namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class GetBackgroundColorsCommand : ICommand<GetBackgroundColorsCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.getBackgroundColors";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of the node to get background colors for.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
    }

    public sealed class GetBackgroundColorsCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// The range of background colors behind this element, if it contains any visible text. If no visible text is present, this will be undefined. In the case of a flat background color, this will consist of simply that color. In the case of a gradient, this will consist of each of the color stops. For anything more complicated, this will be an empty array. Images will be ignored (as if the image had failed to load).
        ///</summary>
        
        [JsonProperty("backgroundColors")]
        public string[] BackgroundColors
        {
            get;
            set;
        }
    
    }
}