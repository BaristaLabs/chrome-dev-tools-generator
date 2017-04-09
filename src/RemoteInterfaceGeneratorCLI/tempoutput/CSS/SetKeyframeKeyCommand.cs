namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Modifies the keyframe rule key text.
    /// </summary>
    public sealed class SetKeyframeKeyCommand : ICommand<SetKeyframeKeyCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.setKeyframeKey";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Gets or sets the styleSheetId
        /// </summary>
        
        [JsonProperty("styleSheetId")]
        public string StyleSheetId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the range
        /// </summary>
        
        [JsonProperty("range")]
        public SourceRange Range
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the keyText
        /// </summary>
        
        [JsonProperty("keyText")]
        public string KeyText
        {
            get;
            set;
        }
    
    }

    public sealed class SetKeyframeKeyCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// The resulting key text after modification.
        ///</summary>
        
        [JsonProperty("keyText")]
        public Value KeyText
        {
            get;
            set;
        }
    
    }
}