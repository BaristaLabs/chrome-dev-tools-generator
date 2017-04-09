namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sends protocol message to the target with given id.
    /// </summary>
    public sealed class SendMessageToTargetCommand : ICommand<SendMessageToTargetCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Target.sendMessageToTarget";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Gets or sets the targetId
        /// </summary>
        
        [JsonProperty("targetId")]
        public string TargetId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the message
        /// </summary>
        
        [JsonProperty("message")]
        public string Message
        {
            get;
            set;
        }
    
    }

    public sealed class SendMessageToTargetCommandResponse : ICommandResponse
    {
    
    }
}