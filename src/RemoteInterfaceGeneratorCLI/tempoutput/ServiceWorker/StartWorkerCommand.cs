namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class StartWorkerCommand : ICommand<StartWorkerCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "ServiceWorker.startWorker";
        
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

    public sealed class StartWorkerCommandResponse : ICommandResponse
    {
    
    }
}