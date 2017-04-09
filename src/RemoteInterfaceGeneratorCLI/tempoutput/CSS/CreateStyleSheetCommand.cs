namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Creates a new special "via-inspector" stylesheet in the frame with given <code>frameId</code>.
    /// </summary>
    public sealed class CreateStyleSheetCommand : ICommand<CreateStyleSheetCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.createStyleSheet";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Identifier of the frame where "via-inspector" stylesheet should be created.
        /// </summary>
        
        [JsonProperty("frameId")]
        public string FrameId
        {
            get;
            set;
        }
    
    }

    public sealed class CreateStyleSheetCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Identifier of the created "via-inspector" stylesheet.
        ///</summary>
        
        [JsonProperty("styleSheetId")]
        public string StyleSheetId
        {
            get;
            set;
        }
    
    }
}