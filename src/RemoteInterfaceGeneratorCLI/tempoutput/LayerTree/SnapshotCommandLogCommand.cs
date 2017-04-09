namespace BaristaLabs.ChromeDevTools.Runtime.LayerTree
{
    using Newtonsoft.Json;

    /// <summary>
    /// Replays the layer snapshot and returns canvas log.
    /// </summary>
    public sealed class SnapshotCommandLogCommand : ICommand<SnapshotCommandLogCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "LayerTree.snapshotCommandLog";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// The id of the layer snapshot.
        /// </summary>
        
        [JsonProperty("snapshotId")]
        public string SnapshotId
        {
            get;
            set;
        }
    
    }

    public sealed class SnapshotCommandLogCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// The array of canvas function calls.
        ///</summary>
        
        [JsonProperty("commandLog")]
        public object[] CommandLog
        {
            get;
            set;
        }
    
    }
}