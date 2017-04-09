namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Seek a set of animations to a particular time within each animation.
    /// </summary>
    public sealed class SeekAnimationsCommand : ICommand<SeekAnimationsCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Animation.seekAnimations";
        
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
    
        
        /// <summary>
        /// Set the current time of each animation.
        /// </summary>
        
        [JsonProperty("currentTime")]
        public double CurrentTime
        {
            get;
            set;
        }
    
    }

    public sealed class SeekAnimationsCommandResponse : ICommandResponse
    {
    
    }
}