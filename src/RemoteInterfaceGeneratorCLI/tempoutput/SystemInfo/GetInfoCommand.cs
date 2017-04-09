namespace BaristaLabs.ChromeDevTools.Runtime.SystemInfo
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns information about the system.
    /// </summary>
    public sealed class GetInfoCommand : ICommand<GetInfoCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "SystemInfo.getInfo";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class GetInfoCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Information about the GPUs on the system.
        ///</summary>
        
        [JsonProperty("gpu")]
        public GPUInfo Gpu
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// A platform-dependent description of the model of the machine. On Mac OS, this is, for example, 'MacBookPro'. Will be the empty string if not supported.
        ///</summary>
        
        [JsonProperty("modelName")]
        public string ModelName
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// A platform-dependent description of the version of the machine. On Mac OS, this is, for example, '10.1'. Will be the empty string if not supported.
        ///</summary>
        
        [JsonProperty("modelVersion")]
        public string ModelVersion
        {
            get;
            set;
        }
    
    }
}