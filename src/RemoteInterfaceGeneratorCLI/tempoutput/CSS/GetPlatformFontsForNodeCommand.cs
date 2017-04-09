namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Requests information about platform fonts which we used to render child TextNodes in the given node.
    /// </summary>
    public sealed class GetPlatformFontsForNodeCommand : ICommand<GetPlatformFontsForNodeCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.getPlatformFontsForNode";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Gets or sets the nodeId
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
    }

    public sealed class GetPlatformFontsForNodeCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Usage statistics for every employed platform font.
        ///</summary>
        
        [JsonProperty("fonts")]
        public PlatformFontUsage[] Fonts
        {
            get;
            set;
        }
    
    }
}