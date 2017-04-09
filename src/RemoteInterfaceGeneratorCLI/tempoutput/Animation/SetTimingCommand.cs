namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets the timing of an animation node.
    /// </summary>
    public sealed class SetTimingCommand : ICommand<SetTimingCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Animation.setTiming";
        
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
    
        
        /// <summary>
        /// Duration of the animation.
        /// </summary>
        
        [JsonProperty("duration")]
        public double Duration
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Delay of the animation.
        /// </summary>
        
        [JsonProperty("delay")]
        public double Delay
        {
            get;
            set;
        }
    
    }

    public sealed class SetTimingCommandResponse : ICommandResponse
    {
    
    }
}