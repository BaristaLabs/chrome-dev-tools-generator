namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the DER-encoded certificate.
    /// </summary>
    public sealed class GetCertificateCommand : ICommand<GetCertificateCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Network.getCertificate";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Origin to get certificate for.
        /// </summary>
        
        [JsonProperty("origin")]
        public string Origin
        {
            get;
            set;
        }
    
    }

    public sealed class GetCertificateCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Gets or sets the tableNames
        /// </summary>
        
        [JsonProperty("tableNames")]
        public string[] TableNames
        {
            get;
            set;
        }
    
    }
}