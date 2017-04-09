namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    using Newtonsoft.Json;

    /// <summary>
    /// For testing.
    /// </summary>
    public sealed class SetDataSizeLimitsForTestCommand : ICommand<SetDataSizeLimitsForTestCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Network.setDataSizeLimitsForTest";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Maximum total buffer size.
        /// </summary>
        
        [JsonProperty("maxTotalSize")]
        public long MaxTotalSize
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Maximum per-resource size.
        /// </summary>
        
        [JsonProperty("maxResourceSize")]
        public long MaxResourceSize
        {
            get;
            set;
        }
    
    }

    public sealed class SetDataSizeLimitsForTestCommandResponse : ICommandResponse
    {
    
    }
}