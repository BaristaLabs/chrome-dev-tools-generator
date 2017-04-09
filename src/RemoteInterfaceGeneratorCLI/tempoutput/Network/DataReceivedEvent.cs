namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    /// <summary>
    /// Fired when data chunk was received over the network.
    /// </summary>
    public sealed class DataReceivedEvent : IEvent
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
        /// Data chunk length.
        /// </summary>
        
        public long DataLength
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Actual bytes received (might be less than dataLength for compressed encodings).
        /// </summary>
        
        public long EncodedDataLength
        {
            get;
            set;
        }
    
    }
}