namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    /// <summary>
    /// Fired when HTTP request has finished loading.
    /// </summary>
    public sealed class LoadingFinishedEvent : IEvent
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
        /// Total number of bytes received for this request.
        /// </summary>
        
        public double EncodedDataLength
        {
            get;
            set;
        }
    
    }
}