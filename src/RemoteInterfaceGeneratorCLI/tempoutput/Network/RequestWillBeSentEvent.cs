namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    /// <summary>
    /// Fired when page is about to send HTTP request.
    /// </summary>
    public sealed class RequestWillBeSentEvent : IEvent
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
        /// URL of the document this request is loaded for.
        /// </summary>
        
        public string DocumentURL
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Request data.
        /// </summary>
        
        public Request Request
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
        /// UTC Timestamp.
        /// </summary>
        
        public double WallTime
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
    
        
        /// <summary>
        /// Redirect response data.
        /// </summary>
        
        public Response RedirectResponse
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Type of this resource.
        /// </summary>
        
        public BaristaLabs.ChromeDevTools.Runtime.Page.ResourceType Type
        {
            get;
            set;
        }
    
    }
}