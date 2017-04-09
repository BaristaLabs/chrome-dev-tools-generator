namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    /// <summary>
    /// Fired when WebSocket handshake response becomes available.
    /// </summary>
    public sealed class WebSocketHandshakeResponseReceivedEvent : IEvent
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
        /// WebSocket response data.
        /// </summary>
        
        public WebSocketResponse Response
        {
            get;
            set;
        }
    
    }
}