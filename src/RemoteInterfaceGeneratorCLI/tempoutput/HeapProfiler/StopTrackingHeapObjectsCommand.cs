namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class StopTrackingHeapObjectsCommand : ICommand<StopTrackingHeapObjectsCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "HeapProfiler.stopTrackingHeapObjects";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// If true 'reportHeapSnapshotProgress' events will be generated while snapshot is being taken when the tracking is stopped.
        /// </summary>
        
        [JsonProperty("reportProgress")]
        public bool ReportProgress
        {
            get;
            set;
        }
    
    }

    public sealed class StopTrackingHeapObjectsCommandResponse : ICommandResponse
    {
    
    }
}