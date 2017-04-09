namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class UpdateRegistrationCommand : ICommand<UpdateRegistrationCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "ServiceWorker.updateRegistration";
        
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

    public sealed class UpdateRegistrationCommandResponse : ICommandResponse
    {
    
    }
}