namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Modifies the rule selector.
    /// </summary>
    public sealed class SetRuleSelectorCommand : ICommand<SetRuleSelectorCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.setRuleSelector";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Gets or sets the styleSheetId
        /// </summary>
        
        [JsonProperty("styleSheetId")]
        public string StyleSheetId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the range
        /// </summary>
        
        [JsonProperty("range")]
        public SourceRange Range
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the selector
        /// </summary>
        
        [JsonProperty("selector")]
        public string Selector
        {
            get;
            set;
        }
    
    }

    public sealed class SetRuleSelectorCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// The resulting selector list after modification.
        ///</summary>
        
        [JsonProperty("selectorList")]
        public SelectorList SelectorList
        {
            get;
            set;
        }
    
    }
}