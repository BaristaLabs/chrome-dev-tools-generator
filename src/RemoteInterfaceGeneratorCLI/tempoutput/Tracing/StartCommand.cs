namespace BaristaLabs.ChromeDevTools.Runtime.Tracing
{
    using Newtonsoft.Json;

    /// <summary>
    /// Start trace events collection.
    /// </summary>
    public sealed class StartCommand : ICommand<StartCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Tracing.start";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Category/tag filter
        /// </summary>
        
        [JsonProperty("categories")]
        public string Categories
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Tracing options
        /// </summary>
        
        [JsonProperty("options")]
        public string Options
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// If set, the agent will issue bufferUsage events at this interval, specified in milliseconds
        /// </summary>
        
        [JsonProperty("bufferUsageReportingInterval")]
        public double BufferUsageReportingInterval
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Whether to report trace events as series of dataCollected events or to save trace to a stream (defaults to <code>ReportEvents</code>).
        /// </summary>
        
        [JsonProperty("transferMode")]
        public string TransferMode
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the traceConfig
        /// </summary>
        
        [JsonProperty("traceConfig")]
        public TraceConfig TraceConfig
        {
            get;
            set;
        }
    
    }

    public sealed class StartCommandResponse : ICommandResponse
    {
    
    }
}