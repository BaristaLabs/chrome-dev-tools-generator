namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    /// <summary>
    /// Notifies about new protocol message from attached target.
    /// </summary>
    public sealed class ReceivedMessageFromTargetEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the targetId
        /// </summary>
        
        public string TargetId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the message
        /// </summary>
        
        public string Message
        {
            get;
            set;
        }
    
    }
}