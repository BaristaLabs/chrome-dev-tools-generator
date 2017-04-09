namespace BaristaLabs.ChromeDevTools.Runtime.DOMDebugger
{
    /// <summary>
    /// DOM breakpoint type.
    /// </summary>
    public sealed class DOMBreakpointType
    {
        private string m_value;

        private DOMBreakpointType(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static DOMBreakpointType SubtreeModified = new DOMBreakpointType("subtree-modified");
    
        public static DOMBreakpointType AttributeModified = new DOMBreakpointType("attribute-modified");
    
        public static DOMBreakpointType NodeRemoved = new DOMBreakpointType("node-removed");
    
    }
}