namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    /// <summary>
    /// Event for when an animation has been cancelled.
    /// </summary>
    public sealed class AnimationCanceledEvent : IEvent
    {
    
        
        /// <summary>
        /// Id of the animation that was cancelled.
        /// </summary>
        
        public string Id
        {
            get;
            set;
        }
    
    }
}