namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    /// <summary>
    /// Event for animation that has been started.
    /// </summary>
    public sealed class AnimationStartedEvent : IEvent
    {
    
        
        /// <summary>
        /// Animation that was started.
        /// </summary>
        
        public Animation Animation
        {
            get;
            set;
        }
    
    }
}