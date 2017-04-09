namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Acknowledges that a screencast frame has been received by the frontend.
    /// </summary>
    public sealed class ScreencastFrameAckCommand : ICommand<ScreencastFrameAckCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.screencastFrameAck";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Frame number.
        /// </summary>
        
        [JsonProperty("sessionId")]
        public long SessionId
        {
            get;
            set;
        }
    
    }

    public sealed class ScreencastFrameAckCommandResponse : ICommandResponse
    {
    
    }
}