namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Applies specified style edits one after another in the given order.
    /// </summary>
    public sealed class SetStyleTextsCommand : ICommand<SetStyleTextsCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.setStyleTexts";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Gets or sets the edits
        /// </summary>
        
        [JsonProperty("edits")]
        public StyleDeclarationEdit[] Edits
        {
            get;
            set;
        }
    
    }

    public sealed class SetStyleTextsCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// The resulting styles after modification.
        ///</summary>
        
        [JsonProperty("styles")]
        public CSSStyle[] Styles
        {
            get;
            set;
        }
    
    }
}