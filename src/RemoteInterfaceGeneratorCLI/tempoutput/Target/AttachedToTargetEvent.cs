namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    /// <summary>
    /// Issued when attached to target because of auto-attach or <code>attachToTarget</code> command.
    /// </summary>
    public sealed class AttachedToTargetEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the targetInfo
        /// </summary>
        
        public TargetInfo TargetInfo
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Gets or sets the waitingForDebugger
        /// </summary>
        
        public bool WaitingForDebugger
        {
            get;
            set;
        }
    
    }
}