namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Attaches to the target with given id.
    /// </summary>
    public sealed class AttachToTargetCommand : ICommand<AttachToTargetCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Target.attachToTarget";
        
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
    
    }

    public sealed class AttachToTargetCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Whether attach succeeded.
        ///</summary>
        
        [JsonProperty("success")]
        public bool Success
        {
            get;
            set;
        }
    
    }
}