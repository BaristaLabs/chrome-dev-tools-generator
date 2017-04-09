namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    /// <summary>
    /// Fired when frame has been detached from its parent.
    /// </summary>
    public sealed class FrameDetachedEvent : IEvent
    {
    
        
        /// <summary>
        /// Id of the frame that has been detached.
        /// </summary>
        
        public string FrameId
        {
            get;
            set;
        }
    
    }
}