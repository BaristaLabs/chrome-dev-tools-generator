namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class SetAttachToFramesCommand : ICommand<SetAttachToFramesCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Target.setAttachToFrames";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Whether to attach to frames.
        /// </summary>
        
        [JsonProperty("value")]
        public bool Value
        {
            get;
            set;
        }
    
    }

    public sealed class SetAttachToFramesCommandResponse : ICommandResponse
    {
    
    }
}