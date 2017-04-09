namespace BaristaLabs.ChromeDevTools.Runtime.Database
{
    /// <summary>
    /// Database error.
    /// </summary>
    public sealed class Error
    {
    
        /// <summary>
        /// Error message.
        ///</summary>
        public string Message
        {
            get;
            set;
        }
    
        /// <summary>
        /// Error code.
        ///</summary>
        public long Code
        {
            get;
            set;
        }
    
    }
}