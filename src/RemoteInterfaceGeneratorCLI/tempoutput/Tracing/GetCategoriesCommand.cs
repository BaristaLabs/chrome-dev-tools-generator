namespace BaristaLabs.ChromeDevTools.Runtime.Tracing
{
    using Newtonsoft.Json;

    /// <summary>
    /// Gets supported tracing categories.
    /// </summary>
    public sealed class GetCategoriesCommand : ICommand<GetCategoriesCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Tracing.getCategories";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
    }

    public sealed class GetCategoriesCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// A list of supported tracing categories.
        ///</summary>
        
        [JsonProperty("categories")]
        public string[] Categories
        {
            get;
            set;
        }
    
    }
}