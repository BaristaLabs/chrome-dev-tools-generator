namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Specifies whether to always send extra HTTP headers with the requests from this page.
    /// </summary>
    public sealed class SetExtraHTTPHeadersCommand : ICommand<SetExtraHTTPHeadersCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Network.setExtraHTTPHeaders";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Map with extra HTTP headers.
        /// </summary>
        
        [JsonProperty("headers")]
        public Headers Headers
        {
            get;
            set;
        }
    
    }

    public sealed class SetExtraHTTPHeadersCommandResponse : ICommandResponse
    {
    
    }
}