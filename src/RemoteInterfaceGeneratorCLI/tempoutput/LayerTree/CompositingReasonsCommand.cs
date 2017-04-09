namespace BaristaLabs.ChromeDevTools.Runtime.LayerTree
{
    using Newtonsoft.Json;

    /// <summary>
    /// Provides the reasons why the given layer was composited.
    /// </summary>
    public sealed class CompositingReasonsCommand : ICommand<CompositingReasonsCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "LayerTree.compositingReasons";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// The id of the layer for which we want to get the reasons it was composited.
        /// </summary>
        
        [JsonProperty("layerId")]
        public string LayerId
        {
            get;
            set;
        }
    
    }

    public sealed class CompositingReasonsCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// A list of strings specifying reasons for the given layer to become composited.
        ///</summary>
        
        [JsonProperty("compositingReasons")]
        public string[] CompositingReasons
        {
            get;
            set;
        }
    
    }
}