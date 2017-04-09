namespace BaristaLabs.ChromeDevTools.Runtime.LayerTree
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns the layer snapshot identifier.
    /// </summary>
    public sealed class MakeSnapshotCommand : ICommand<MakeSnapshotCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "LayerTree.makeSnapshot";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// The id of the layer.
        /// </summary>
        
        [JsonProperty("layerId")]
        public string LayerId
        {
            get;
            set;
        }
    
    }

    public sealed class MakeSnapshotCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// The id of the layer snapshot.
        ///</summary>
        
        [JsonProperty("snapshotId")]
        public string SnapshotId
        {
            get;
            set;
        }
    
    }
}