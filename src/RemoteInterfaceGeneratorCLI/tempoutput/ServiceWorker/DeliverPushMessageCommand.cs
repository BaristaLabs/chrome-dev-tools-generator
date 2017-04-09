namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class DeliverPushMessageCommand : ICommand<DeliverPushMessageCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "ServiceWorker.deliverPushMessage";
        
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
        /// Gets or sets the data
        /// </summary>
        
        [JsonProperty("data")]
        public string Data
        {
            get;
            set;
        }
    
    }

    public sealed class DeliverPushMessageCommandResponse : ICommandResponse
    {
    
    }
}