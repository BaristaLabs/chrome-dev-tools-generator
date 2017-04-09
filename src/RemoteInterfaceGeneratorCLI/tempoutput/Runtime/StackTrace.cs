namespace BaristaLabs.ChromeDevTools.Runtime.Runtime
{
    /// <summary>
    /// Call frames for assertions or error messages.
    /// </summary>
    public sealed class StackTrace
    {
    
        /// <summary>
        /// String label of this stack trace. For async traces this may be a name of the function that initiated the async call.
        ///</summary>
        public string Description
        {
            get;
            set;
        }
    
        /// <summary>
        /// JavaScript function name.
        ///</summary>
        public CallFrame[] CallFrames
        {
            get;
            set;
        }
    
        /// <summary>
        /// Asynchronous JavaScript stack trace that preceded this stack, if available.
        ///</summary>
        public StackTrace Parent
        {
            get;
            set;
        }
    
    }
}