namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    /// <summary>
    /// Enum of possible property sources.
    /// </summary>
    public sealed class AXValueSourceType
    {
        private string m_value;

        private AXValueSourceType(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static AXValueSourceType Attribute = new AXValueSourceType("attribute");
    
        public static AXValueSourceType Implicit = new AXValueSourceType("implicit");
    
        public static AXValueSourceType Style = new AXValueSourceType("style");
    
        public static AXValueSourceType Contents = new AXValueSourceType("contents");
    
        public static AXValueSourceType Placeholder = new AXValueSourceType("placeholder");
    
        public static AXValueSourceType RelatedElement = new AXValueSourceType("relatedElement");
    
    }
}