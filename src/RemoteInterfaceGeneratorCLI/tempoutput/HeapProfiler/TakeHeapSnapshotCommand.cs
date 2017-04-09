namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class TakeHeapSnapshotCommand : ICommand<TakeHeapSnapshotCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "HeapProfiler.takeHeapSnapshot";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// If true 'reportHeapSnapshotProgress' events will be generated while snapshot is being taken.
        /// </summary>
        
        [JsonProperty("reportProgress")]
        public bool ReportProgress
        {
            get;
            set;
        }
    
    }

    public sealed class TakeHeapSnapshotCommandResponse : ICommandResponse
    {
    
    }
}