namespace BaristaLabs.ChromeDevTools.Runtime.Security
{
    /// <summary>
    /// An explanation of an factor contributing to the security state.
    /// </summary>
    public sealed class SecurityStateExplanation
    {
    
        /// <summary>
        /// Security state representing the severity of the factor being explained.
        ///</summary>
        public SecurityState SecurityState
        {
            get;
            set;
        }
    
        /// <summary>
        /// Short phrase describing the type of factor.
        ///</summary>
        public string Summary
        {
            get;
            set;
        }
    
        /// <summary>
        /// Full text explanation of the factor.
        ///</summary>
        public string Description
        {
            get;
            set;
        }
    
        /// <summary>
        /// True if the page has a certificate.
        ///</summary>
        public bool HasCertificate
        {
            get;
            set;
        }
    
    }
}