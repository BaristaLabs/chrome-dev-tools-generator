namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    /// <summary>
    /// Fired when frame has started loading.
    /// </summary>
    public sealed class FrameStartedLoadingEvent : IEvent
    {
    
        
        /// <summary>
        /// Id of the frame that has started loading.
        /// </summary>
        
        public string FrameId
        {
            get;
            set;
        }
    
    }
}