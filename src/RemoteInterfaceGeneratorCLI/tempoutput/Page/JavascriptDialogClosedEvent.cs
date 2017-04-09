namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    /// <summary>
    /// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) has been closed.
    /// </summary>
    public sealed class JavascriptDialogClosedEvent : IEvent
    {
    
        
        /// <summary>
        /// Whether dialog was confirmed.
        /// </summary>
        
        public bool Result
        {
            get;
            set;
        }
    
    }
}