namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns all media queries parsed by the rendering engine.
    /// </summary>
    public sealed class GetMediaQueriesCommand : ICommand<GetMediaQueriesCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.getMediaQueries";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class GetMediaQueriesCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Gets or sets the medias
        /// </summary>
        
        [JsonProperty("medias")]
        public CSSMedia[] Medias
        {
            get;
            set;
        }
    
    }
}