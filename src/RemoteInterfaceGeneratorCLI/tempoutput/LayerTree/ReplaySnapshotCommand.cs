namespace BaristaLabs.ChromeDevTools.Runtime.LayerTree
{
    using Newtonsoft.Json;

    /// <summary>
    /// Replays the layer snapshot and returns the resulting bitmap.
    /// </summary>
    public sealed class ReplaySnapshotCommand : ICommand<ReplaySnapshotCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "LayerTree.replaySnapshot";
        
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
    
        
        /// <summary>
        /// The first step to replay from (replay from the very start if not specified).
        /// </summary>
        
        [JsonProperty("fromStep")]
        public long FromStep
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// The last step to replay to (replay till the end if not specified).
        /// </summary>
        
        [JsonProperty("toStep")]
        public long ToStep
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// The scale to apply while replaying (defaults to 1).
        /// </summary>
        
        [JsonProperty("scale")]
        public double Scale
        {
            get;
            set;
        }
    
    }

    public sealed class ReplaySnapshotCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// A data: URL for resulting image.
        ///</summary>
        
        [JsonProperty("dataURL")]
        public string DataURL
        {
            get;
            set;
        }
    
    }
}