namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Inserts a new rule with the given <code>ruleText</code> in a stylesheet with given <code>styleSheetId</code>, at the position specified by <code>location</code>.
    /// </summary>
    public sealed class AddRuleCommand : ICommand<AddRuleCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.addRule";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// The css style sheet identifier where a new rule should be inserted.
        /// </summary>
        
        [JsonProperty("styleSheetId")]
        public string StyleSheetId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// The text of a new rule.
        /// </summary>
        
        [JsonProperty("ruleText")]
        public string RuleText
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Text position of a new rule in the target style sheet.
        /// </summary>
        
        [JsonProperty("location")]
        public SourceRange Location
        {
            get;
            set;
        }
    
    }

    public sealed class AddRuleCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// The newly created rule.
        ///</summary>
        
        [JsonProperty("rule")]
        public CSSRule Rule
        {
            get;
            set;
        }
    
    }
}