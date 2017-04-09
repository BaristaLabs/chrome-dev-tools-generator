namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// Activates (focuses) the target.
    /// </summary>
    public sealed class ActivateTargetCommand : ICommand<ActivateTargetCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Target.activateTarget";
        
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

    public sealed class ActivateTargetCommandResponse : ICommandResponse
    {
    
    }
}