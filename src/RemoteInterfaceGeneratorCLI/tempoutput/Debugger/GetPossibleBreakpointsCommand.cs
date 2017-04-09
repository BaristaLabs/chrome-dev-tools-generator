namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    using Newtonsoft.Json;

    /// <summary>
    /// Returns possible locations for breakpoint. scriptId in start and end range locations should be the same.
    /// </summary>
    public sealed class GetPossibleBreakpointsCommand : ICommand<GetPossibleBreakpointsCommandResponse>
    {
        private const string ChromeRemoteInterface_CommandName = "Debugger.getPossibleBreakpoints";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    
        
        /// <summary>
        /// Start of range to search possible breakpoint locations in.
        /// </summary>
        
        [JsonProperty("start")]
        public Location Start
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// End of range to search possible breakpoint locations in (excluding). When not specifed, end of scripts is used as end of range.
        /// </summary>
        
        [JsonProperty("end")]
        public Location End
        {
            get;
            set;
        }
    
    }

    public sealed class GetPossibleBreakpointsCommandResponse : ICommandResponse
    {
    
        
        /// <summary>
        /// List of the possible breakpoint locations.
        ///</summary>
        
        [JsonProperty("locations")]
        public Location[] Locations
        {
            get;
            set;
        }
    
    }
}