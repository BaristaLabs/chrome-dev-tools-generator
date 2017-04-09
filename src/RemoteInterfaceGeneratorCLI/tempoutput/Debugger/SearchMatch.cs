namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    /// <summary>
    /// Search match for resource.
    /// </summary>
    public sealed class SearchMatch
    {
    
        /// <summary>
        /// Line number in resource content.
        ///</summary>
        public double LineNumber
        {
            get;
            set;
        }
    
        /// <summary>
        /// Line with match content.
        ///</summary>
        public string LineContent
        {
            get;
            set;
        }
    
    }
}