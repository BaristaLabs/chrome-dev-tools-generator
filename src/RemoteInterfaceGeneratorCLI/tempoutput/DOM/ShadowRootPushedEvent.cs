namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    /// <summary>
    /// Called when shadow root is pushed into the element.
    /// </summary>
    public sealed class ShadowRootPushedEvent : IEvent
    {
    
        
        /// <summary>
        /// Host element id.
        /// </summary>
        
        public long HostId
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Shadow root.
        /// </summary>
        
        public Node Root
        {
            get;
            set;
        }
    
    }
}