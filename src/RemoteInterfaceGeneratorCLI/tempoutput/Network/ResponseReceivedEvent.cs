namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    /// <summary>
    /// Fired when HTTP response is available.
    /// </summary>
    public sealed class ResponseReceivedEvent : IEvent
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
        /// Frame identifier.
        /// </summary>
        
        public string FrameId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Loader identifier.
        /// </summary>
        
        public string LoaderId
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
        /// Resource type.
        /// </summary>
        
        public BaristaLabs.ChromeDevTools.Runtime.Page.ResourceType Type
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Response data.
        /// </summary>
        
        public Response Response
        {
            get;
            set;
        }
    
    }
}