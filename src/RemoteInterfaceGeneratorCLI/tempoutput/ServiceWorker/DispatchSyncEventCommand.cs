namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class DispatchSyncEventCommand : ICommand<DispatchSyncEventCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "ServiceWorker.dispatchSyncEvent";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Gets or sets the origin
        /// </summary>
        
        [JsonProperty("origin")]
        public string Origin
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the registrationId
        /// </summary>
        
        [JsonProperty("registrationId")]
        public string RegistrationId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the tag
        /// </summary>
        
        [JsonProperty("tag")]
        public string Tag
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the lastChance
        /// </summary>
        
        [JsonProperty("lastChance")]
        public bool LastChance
        {
            get;
            set;
        }
    
    }

    public sealed class DispatchSyncEventCommandResponse : ICommandResponse
    {
    
    }
}