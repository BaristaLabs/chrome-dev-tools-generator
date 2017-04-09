namespace BaristaLabs.ChromeDevTools.Runtime.Console
{
    /// <summary>
    /// Console message.
    /// </summary>
    public sealed class ConsoleMessage
    {
    
        /// <summary>
        /// Message source.
        ///</summary>
        public string Source
        {
            get;
            set;
        }
    
        /// <summary>
        /// Message severity.
        ///</summary>
        public string Level
        {
            get;
            set;
        }
    
        /// <summary>
        /// Message text.
        ///</summary>
        public string Text
        {
            get;
            set;
        }
    
        /// <summary>
        /// URL of the message origin.
        ///</summary>
        public string Url
        {
            get;
            set;
        }
    
        /// <summary>
        /// Line number in the resource that generated this message (1-based).
        ///</summary>
        public long Line
        {
            get;
            set;
        }
    
        /// <summary>
        /// Column number in the resource that generated this message (1-based).
        ///</summary>
        public long Column
        {
            get;
            set;
        }
    
    }
}