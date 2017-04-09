namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Releases a set of animations to no longer be manipulated.
    /// </summary>
    public sealed class ReleaseAnimationsCommand : ICommand<ReleaseAnimationsCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Animation.releaseAnimations";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// List of animation ids to seek.
        /// </summary>
        
        [JsonProperty("animations")]
        public string[] Animations
        {
            get;
            set;
        }
    
    }

    public sealed class ReleaseAnimationsCommandResponse : ICommandResponse
    {
    
    }
}