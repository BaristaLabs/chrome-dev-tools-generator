namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    /// <summary>
    /// Information about the Frame hierarchy along with their cached resources.
    /// </summary>
    public sealed class FrameResourceTree
    {
    
        /// <summary>
        /// Frame information for this tree item.
        ///</summary>
        public Frame Frame
        {
            get;
            set;
        }
    
        /// <summary>
        /// Child frames.
        ///</summary>
        public FrameResourceTree[] ChildFrames
        {
            get;
            set;
        }
    
        /// <summary>
        /// Information about frame resources.
        ///</summary>
        public FrameResource[] Resources
        {
            get;
            set;
        }
    
    }
}