namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    /// <summary>
    /// Fired upon WebSocket creation.
    /// </summary>
    public sealed class WebSocketCreatedEvent : IEvent
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
        /// WebSocket request URL.
        /// </summary>
        
        public string Url
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Request initiator.
        /// </summary>
        
        public Initiator Initiator
        {
            get;
            set;
        }
    
    }
}