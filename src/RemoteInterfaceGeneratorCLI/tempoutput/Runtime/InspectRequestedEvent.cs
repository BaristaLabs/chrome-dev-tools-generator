namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    /// <summary>
    /// Issued when object should be inspected (for example, as a result of inspect() command line API call).
    /// </summary>
    public sealed class InspectRequestedEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the object
        /// </summary>
        
        public RemoteObject Object
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the hints
        /// </summary>
        
        public object Hints
        {
            get;
            set;
        }
    
    }
}