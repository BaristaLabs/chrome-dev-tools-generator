namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    /// <summary>
    /// Issued when a possible inspection target is created.
    /// </summary>
    public sealed class TargetCreatedEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the targetInfo
        /// </summary>
        
        public TargetInfo TargetInfo
        {
            get;
            set;
        }
    
    }
}