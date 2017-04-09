namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Releases remote object with given id.
    /// </summary>
    public sealed class ReleaseObjectCommand : ICommand<ReleaseObjectCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Runtime.releaseObject";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Identifier of the object to release.
        /// </summary>
        
        [JsonProperty("objectId")]
        public string ObjectId
        {
            get;
            set;
        }
    
    }

    public sealed class ReleaseObjectCommandResponse : ICommandResponse
    {
    
    }
}