namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    using Newtonsoft.Json;

    /// <summary>
    /// Gets the playback rate of the document timeline.
    /// </summary>
    public sealed class GetPlaybackRateCommand : ICommand<GetPlaybackRateCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Animation.getPlaybackRate";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class GetPlaybackRateCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Playback rate for animations on page.
        ///</summary>
        
        [JsonProperty("playbackRate")]
        public double PlaybackRate
        {
            get;
            set;
        }
    
    }
}