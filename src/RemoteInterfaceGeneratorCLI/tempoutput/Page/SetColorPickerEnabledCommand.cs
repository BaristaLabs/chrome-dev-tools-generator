namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    using Newtonsoft.Json;

    /// <summary>
    /// Shows / hides color picker
    /// </summary>
    public sealed class SetColorPickerEnabledCommand : ICommand<SetColorPickerEnabledCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Page.setColorPickerEnabled";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Shows / hides color picker
        /// </summary>
        
        [JsonProperty("enabled")]
        public bool Enabled
        {
            get;
            set;
        }
    
    }

    public sealed class SetColorPickerEnabledCommandResponse : ICommandResponse
    {
    
    }
}