namespace BaristaLabs.ChromeDevTools.Runtime.IO
{
    using Newtonsoft.Json;

    /// <summary>
    /// Close the stream, discard any temporary backing storage.
    /// </summary>
    public sealed class CloseCommand : ICommand<CloseCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "IO.close";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Handle of the stream to close.
        /// </summary>
        
        [JsonProperty("handle")]
        public string Handle
        {
            get;
            set;
        }
    
    }

    public sealed class CloseCommandResponse : ICommandResponse
    {
    
    }
}