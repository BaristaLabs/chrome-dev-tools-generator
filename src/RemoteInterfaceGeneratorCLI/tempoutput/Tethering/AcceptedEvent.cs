namespace BaristaLabs.ChromeDevTools.Runtime.Tethering
{
    /// <summary>
    /// Informs that port was successfully bound and got a specified connection id.
    /// </summary>
    public sealed class AcceptedEvent : IEvent
    {
    
        
        /// <summary>
        /// Port number that was successfully bound.
        /// </summary>
        
        public long Port
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Connection id to be used.
        /// </summary>
        
        public string ConnectionId
        {
            get;
            set;
        }
    
    }
}