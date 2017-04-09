namespace BaristaLabs.ChromeDevTools.Runtime.Tracing
{
    using Newtonsoft.Json;

    /// <summary>
    /// Request a global memory dump.
    /// </summary>
    public sealed class RequestMemoryDumpCommand : ICommand<RequestMemoryDumpCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Tracing.requestMemoryDump";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class RequestMemoryDumpCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// GUID of the resulting global memory dump.
        ///</summary>
        
        [JsonProperty("dumpGuid")]
        public string DumpGuid
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// True iff the global memory dump succeeded.
        ///</summary>
        
        [JsonProperty("success")]
        public bool Success
        {
            get;
            set;
        }
    
    }
}