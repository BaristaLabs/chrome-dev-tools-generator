namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Controls whether browser will open a new inspector window for connected pages.
    /// </summary>
    public sealed class SetAutoAttachToCreatedPagesCommand : ICommand<SetAutoAttachToCreatedPagesCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.setAutoAttachToCreatedPages";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// If true, browser will open a new inspector window for every page created from this one.
        /// </summary>
        
        [JsonProperty("autoAttach")]
        public bool AutoAttach
        {
            get;
            set;
        }
    
    }

    public sealed class SetAutoAttachToCreatedPagesCommandResponse : ICommandResponse
    {
    
    }
}