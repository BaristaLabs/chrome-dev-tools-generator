namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class GetHeapObjectIdCommand : ICommand<GetHeapObjectIdCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "HeapProfiler.getHeapObjectId";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Identifier of the object to get heap object id for.
        /// </summary>
        
        [JsonProperty("objectId")]
        public string ObjectId
        {
            get;
            set;
        }
    
    }

    public sealed class GetHeapObjectIdCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Id of the heap snapshot object corresponding to the passed remote object id.
        ///</summary>
        
        [JsonProperty("heapSnapshotObjectId")]
        public string HeapSnapshotObjectId
        {
            get;
            set;
        }
    
    }
}