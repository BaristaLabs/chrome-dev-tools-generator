namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets the playback rate of the document timeline.
    /// </summary>
    public sealed class SetPlaybackRateCommand : ICommand<SetPlaybackRateCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Animation.setPlaybackRate";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Playback rate for animations on page
        /// </summary>
        
        [JsonProperty("playbackRate")]
        public double PlaybackRate
        {
            get;
            set;
        }
    
    }

    public sealed class SetPlaybackRateCommandResponse : ICommandResponse
    {
    
    }
}