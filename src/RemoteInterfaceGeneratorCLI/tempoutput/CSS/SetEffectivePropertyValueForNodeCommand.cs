namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Find a rule with the given active property for the given node and set the new value for this property
    /// </summary>
    public sealed class SetEffectivePropertyValueForNodeCommand : ICommand<SetEffectivePropertyValueForNodeCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "CSS.setEffectivePropertyValueForNode";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// The element id for which to set property.
        /// </summary>
        
        [JsonProperty("nodeId")]
        public long NodeId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the propertyName
        /// </summary>
        
        [JsonProperty("propertyName")]
        public string PropertyName
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the value
        /// </summary>
        
        [JsonProperty("value")]
        public string Value
        {
            get;
            set;
        }
    
    }

    public sealed class SetEffectivePropertyValueForNodeCommandResponse : ICommandResponse
    {
    
    }
}