namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the current time of the an animation.
    /// </summary>
    public sealed class GetCurrentTimeCommand : ICommand<GetCurrentTimeCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Animation.getCurrentTime";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of animation.
        /// </summary>
        
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }
    
    }

    public sealed class GetCurrentTimeCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Current time of the page.
        ///</summary>
        
        [JsonProperty("currentTime")]
        public double CurrentTime
        {
            get;
            set;
        }
    
    }
}