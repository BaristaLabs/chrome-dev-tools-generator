namespace BaristaLabs.ChromeDevTools.Runtime.ServiceWorker
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class InspectWorkerCommand : ICommand<InspectWorkerCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "ServiceWorker.inspectWorker";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Gets or sets the versionId
        /// </summary>
        
        [JsonProperty("versionId")]
        public string VersionId
        {
            get;
            set;
        }
    
    }

    public sealed class InspectWorkerCommandResponse : ICommandResponse
    {
    
    }
}