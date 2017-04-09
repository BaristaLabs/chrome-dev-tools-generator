namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class UnregisterCommand : ICommand<UnregisterCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "ServiceWorker.unregister";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Gets or sets the scopeURL
        /// </summary>
        
        [JsonProperty("scopeURL")]
        public string ScopeURL
        {
            get;
            set;
        }
    
    }

    public sealed class UnregisterCommandResponse : ICommandResponse
    {
    
    }
}