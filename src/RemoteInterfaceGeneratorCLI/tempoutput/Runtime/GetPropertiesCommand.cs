namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns properties of a given object. Object group of the result is inherited from the target object.
    /// </summary>
    public sealed class GetPropertiesCommand : ICommand<GetPropertiesCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Runtime.getProperties";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Identifier of the object to return properties for.
        /// </summary>
        
        [JsonProperty("objectId")]
        public string ObjectId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// If true, returns properties belonging only to the element itself, not to its prototype chain.
        /// </summary>
        
        [JsonProperty("ownProperties")]
        public bool OwnProperties
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// If true, returns accessor properties (with getter/setter) only; internal properties are not returned either.
        /// </summary>
        
        [JsonProperty("accessorPropertiesOnly")]
        public bool AccessorPropertiesOnly
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Whether preview should be generated for the results.
        /// </summary>
        
        [JsonProperty("generatePreview")]
        public bool GeneratePreview
        {
            get;
            set;
        }
    
    }

    public sealed class GetPropertiesCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// Object properties.
        ///</summary>
        
        [JsonProperty("result")]
        public PropertyDescriptor[] Result
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Internal object properties (only of the element itself).
        ///</summary>
        
        [JsonProperty("internalProperties")]
        public InternalPropertyDescriptor[] InternalProperties
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Exception details.
        ///</summary>
        
        [JsonProperty("exceptionDetails")]
        public ExceptionDetails ExceptionDetails
        {
            get;
            set;
        }
    
    }
}