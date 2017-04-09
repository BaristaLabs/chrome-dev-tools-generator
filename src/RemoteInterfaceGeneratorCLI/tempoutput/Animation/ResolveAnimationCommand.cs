namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Gets the remote object of the Animation.
    /// </summary>
    public sealed class ResolveAnimationCommand : ICommand<ResolveAnimationCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Animation.resolveAnimation";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Animation id.
        /// </summary>
        
        [JsonProperty("animationId")]
        public string AnimationId
        {
            get;
            set;
        }
    
    }

    public sealed class ResolveAnimationCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Corresponding remote object.
        ///</summary>
        
        [JsonProperty("remoteObject")]
        public BaristaLabs.ChromeDevTools.Runtime.Runtime.RemoteObject RemoteObject
        {
            get;
            set;
        }
    
    }
}