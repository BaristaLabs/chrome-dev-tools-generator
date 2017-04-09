namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns content served for the given request.
    /// </summary>
    public sealed class GetResponseBodyCommand : ICommand<GetResponseBodyCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Network.getResponseBody";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Identifier of the network request to get content for.
        /// </summary>
        
        [JsonProperty("requestId")]
        public string RequestId
        {
            get;
            set;
        }
    
    }

    public sealed class GetResponseBodyCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Response body.
        ///</summary>
        
        [JsonProperty("body")]
        public string Body
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// True, if content was sent as base64.
        ///</summary>
        
        [JsonProperty("base64Encoded")]
        public bool Base64Encoded
        {
            get;
            set;
        }
    
    }
}