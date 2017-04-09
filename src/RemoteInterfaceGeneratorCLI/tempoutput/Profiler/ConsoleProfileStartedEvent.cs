namespace BaristaLabs.ChromeDevTools.Runtime.Profiler
{
    /// <summary>
    /// Sent when new profile recodring is started using console.profile() call.
    /// </summary>
    public sealed class ConsoleProfileStartedEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        
        public string Id
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Location of console.profile().
        /// </summary>
        
        public BaristaLabs.ChromeDevTools.Runtime.Debugger.Location Location
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Profile title passed as an argument to console.profile().
        /// </summary>
        
        public string Title
        {
            get;
            set;
        }
    
    }
}