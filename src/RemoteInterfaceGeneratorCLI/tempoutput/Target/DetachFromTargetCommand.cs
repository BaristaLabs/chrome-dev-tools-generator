namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Detaches from the target with given id.
    /// </summary>
    public sealed class DetachFromTargetCommand : ICommand<DetachFromTargetCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Target.detachFromTarget";
        
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

    public sealed class DetachFromTargetCommandResponse : ICommandResponse
    {
    
    }
}