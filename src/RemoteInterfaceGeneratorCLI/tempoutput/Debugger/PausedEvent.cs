namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    /// <summary>
    /// Fired when the virtual machine stopped on breakpoint or exception or any other stop criteria.
    /// </summary>
    public sealed class PausedEvent : IEvent
    {
    
        
        /// <summary>
        /// Call stack the virtual machine stopped on.
        /// </summary>
        
        public CallFrame[] CallFrames
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Pause reason.
        /// </summary>
        
        public string Reason
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Object containing break-specific auxiliary properties.
        /// </summary>
        
        public object Data
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Hit breakpoints IDs
        /// </summary>
        
        public string[] HitBreakpoints
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Async stack trace, if any.
        /// </summary>
        
        public BaristaLabs.ChromeDevTools.Runtime.Runtime.StackTrace AsyncStackTrace
        {
            get;
            set;
        }
    
    }
}