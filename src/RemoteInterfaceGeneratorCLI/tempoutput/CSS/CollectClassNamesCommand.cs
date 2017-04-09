namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns all class names from specified stylesheet.
    /// </summary>
    public sealed class CollectClassNamesCommand : ICommand<CollectClassNamesCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.collectClassNames";
        
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
    
    }

    public sealed class CollectClassNamesCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Class name list.
        ///</summary>
        
        [JsonProperty("classNames")]
        public string[] ClassNames
        {
            get;
            set;
        }
    
    }
}