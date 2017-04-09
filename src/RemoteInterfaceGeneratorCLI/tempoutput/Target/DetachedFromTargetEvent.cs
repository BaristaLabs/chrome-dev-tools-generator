namespace BaristaLabs.ChromeDevTools.Runtime.Target
{
    /// <summary>
    /// Issued when detached from target for any reason (including <code>detachFromTarget</code> command).
    /// </summary>
    public sealed class DetachedFromTargetEvent : IEvent
    {
    
        
        /// <summary>
        /// Gets or sets the targetId
        /// </summary>
        
        public string TargetId
        {
            get;
            set;
        }
    
    }
}