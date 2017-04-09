namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    /// <summary>
    /// Fired once navigation of the frame has completed. Frame is now associated with the new loader.
    /// </summary>
    public sealed class FrameNavigatedEvent : IEvent
    {
    
        
        /// <summary>
        /// Frame object.
        /// </summary>
        
        public Frame Frame
        {
            get;
            set;
        }
    
    }
}