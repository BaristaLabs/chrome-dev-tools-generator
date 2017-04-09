namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    /// <summary>
    /// Fired when WebSocket frame is received.
    /// </summary>
    public sealed class WebSocketFrameReceivedEvent : IEvent
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
        
        public WebSocketFrame Response
        {
            get;
            set;
        }
    
    }
}