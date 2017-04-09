namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    /// <summary>
    /// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) is about to open.
    /// </summary>
    public sealed class JavascriptDialogOpeningEvent : IEvent
    {
    
        
        /// <summary>
        /// Message that will be displayed by the dialog.
        /// </summary>
        
        public string Message
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Dialog type.
        /// </summary>
        
        public DialogType Type
        {
            get;
            set;
        }
    
    }
}