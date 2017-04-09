namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    /// <summary>
    /// Fired when WebSocket frame error occurs.
    /// </summary>
    public sealed class WebSocketFrameErrorEvent : IEvent
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
        /// WebSocket frame error message.
        /// </summary>
        
        public string ErrorMessage
        {
            get;
            set;
        }
    
    }
}