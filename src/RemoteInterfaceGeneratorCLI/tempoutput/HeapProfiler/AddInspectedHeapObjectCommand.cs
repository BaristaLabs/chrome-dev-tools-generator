namespace BaristaLabs.ChromeDevTools.Runtime.HeapProfiler
{
    using Newtonsoft.Json;

    /// <summary>
    /// Enables console to refer to the node with given id via $x (see Command Line API for more details $x functions).
    /// </summary>
    public sealed class AddInspectedHeapObjectCommand : ICommand<AddInspectedHeapObjectCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "HeapProfiler.addInspectedHeapObject";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Heap snapshot object id to be accessible by means of $x command line API.
        /// </summary>
        
        [JsonProperty("heapObjectId")]
        public string HeapObjectId
        {
            get;
            set;
        }
    
    }

    public sealed class AddInspectedHeapObjectCommandResponse : ICommandResponse
    {
    
    }
}