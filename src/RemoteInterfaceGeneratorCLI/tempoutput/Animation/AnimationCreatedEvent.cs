namespace BaristaLabs.ChromeDevTools.Runtime.Animation
{
    /// <summary>
    /// Event for each animation that has been created.
    /// </summary>
    public sealed class AnimationCreatedEvent : IEvent
    {
    
        
        /// <summary>
        /// Id of the animation that was created.
        /// </summary>
        
        public string Id
        {
            get;
            set;
        }
    
    }
}