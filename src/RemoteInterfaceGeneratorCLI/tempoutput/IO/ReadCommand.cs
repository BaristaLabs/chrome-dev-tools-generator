namespace BaristaLabs.ChromeDevTools.Runtime.IO
{
    using Newtonsoft.Json;

    /// <summary>
    /// Read a chunk of the stream
    /// </summary>
    public sealed class ReadCommand : ICommand<ReadCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "IO.read";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Handle of the stream to read.
        /// </summary>
        
        [JsonProperty("handle")]
        public string Handle
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Seek to the specified offset before reading (if not specificed, proceed with offset following the last read).
        /// </summary>
        
        [JsonProperty("offset")]
        public long Offset
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Maximum number of bytes to read (left upon the agent discretion if not specified).
        /// </summary>
        
        [JsonProperty("size")]
        public long Size
        {
            get;
            set;
        }
    
    }

    public sealed class ReadCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Data that were read.
        ///</summary>
        
        [JsonProperty("data")]
        public string Data
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Set if the end-of-file condition occured while reading.
        ///</summary>
        
        [JsonProperty("eof")]
        public bool Eof
        {
            get;
            set;
        }
    
    }
}