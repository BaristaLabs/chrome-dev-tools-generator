namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Releases all remote objects that belong to a given group.
    /// </summary>
    public sealed class ReleaseObjectGroupCommand : ICommand<ReleaseObjectGroupCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Runtime.releaseObjectGroup";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Symbolic object group name.
        /// </summary>
        
        [JsonProperty("objectGroup")]
        public string ObjectGroup
        {
            get;
            set;
        }
    
    }

    public sealed class ReleaseObjectGroupCommandResponse : ICommandResponse
    {
    
    }
}