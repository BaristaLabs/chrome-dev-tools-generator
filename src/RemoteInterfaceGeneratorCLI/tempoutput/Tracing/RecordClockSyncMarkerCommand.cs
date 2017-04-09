namespace BaristaLabs.ChromeDevTools.Runtime.Tracing
{
    using Newtonsoft.Json;

    /// <summary>
    /// Record a clock sync marker in the trace.
    /// </summary>
    public sealed class RecordClockSyncMarkerCommand : ICommand<RecordClockSyncMarkerCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Tracing.recordClockSyncMarker";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// The ID of this clock sync marker
        /// </summary>
        
        [JsonProperty("syncId")]
        public string SyncId
        {
            get;
            set;
        }
    
    }

    public sealed class RecordClockSyncMarkerCommandResponse : ICommandResponse
    {
    
    }
}