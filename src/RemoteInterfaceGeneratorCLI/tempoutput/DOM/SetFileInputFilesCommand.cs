namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    using Newtonsoft.Json;

    /// <summary>
    /// Sets files for the given file input element.
    /// </summary>
    public sealed class SetFileInputFilesCommand : ICommand<SetFileInputFilesCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "DOM.setFileInputFiles";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Id of the file input node to set files for.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Array of file paths to set.
        /// </summary>
        
        [JsonProperty("files")]
        public string[] Files
        {
            get;
            set;
        }
    
    }

    public sealed class SetFileInputFilesCommandResponse : ICommandResponse
    {
    
    }
}