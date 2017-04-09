namespace BaristaLabs.ChromeDevTools.Runtime.Schema
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns supported domains.
    /// </summary>
    public sealed class GetDomainsCommand : ICommand<GetDomainsCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Schema.getDomains";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class GetDomainsCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// List of supported domains.
        ///</summary>
        
        [JsonProperty("domains")]
        public Domain[] Domains
        {
            get;
            set;
        }
    
    }
}