namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    /// <summary>
    /// Fired when EventSource message is received.
    /// </summary>
    public sealed class EventSourceMessageReceivedEvent : IEvent
    {
    
        
        /// <summary>
        /// Request identifier.
        /// </summary>
        
        public string RequestId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Timestamp.
        /// </summary>
        
        public double Timestamp
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Message type.
        /// </summary>
        
        public string EventName
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Message identifier.
        /// </summary>
        
        public string EventId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Message content.
        /// </summary>
        
        public string Data
        {
            get;
            set;
        }
    
    }
}