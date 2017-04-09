namespace BaristaLabs.ChromeDevTools.Runtime.Security
{
    /// <summary>
    /// The security state of the page changed.
    /// </summary>
    public sealed class SecurityStateChangedEvent : IEvent
    {
    
        
        /// <summary>
        /// Security state.
        /// </summary>
        
        public SecurityState SecurityState
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// True if the page was loaded over cryptographic transport such as HTTPS.
        /// </summary>
        
        public bool SchemeIsCryptographic
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// List of explanations for the security state. If the overall security state is `insecure` or `warning`, at least one corresponding explanation should be included.
        /// </summary>
        
        public SecurityStateExplanation[] Explanations
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Information about insecure content on the page.
        /// </summary>
        
        public InsecureContentStatus InsecureContentStatus
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Overrides user-visible description of the state.
        /// </summary>
        
        public string Summary
        {
            get;
            set;
        }
    
    }
}