namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    /// <summary>
    /// Enum of possible native property sources (as a subtype of a particular AXValueSourceType).
    /// </summary>
    public sealed class AXValueNativeSourceType
    {
        private string m_value;

        private AXValueNativeSourceType(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static AXValueNativeSourceType Figcaption = new AXValueNativeSourceType("figcaption");
    
        public static AXValueNativeSourceType Label = new AXValueNativeSourceType("label");
    
        public static AXValueNativeSourceType Labelfor = new AXValueNativeSourceType("labelfor");
    
        public static AXValueNativeSourceType Labelwrapped = new AXValueNativeSourceType("labelwrapped");
    
        public static AXValueNativeSourceType Legend = new AXValueNativeSourceType("legend");
    
        public static AXValueNativeSourceType Tablecaption = new AXValueNativeSourceType("tablecaption");
    
        public static AXValueNativeSourceType Title = new AXValueNativeSourceType("title");
    
        public static AXValueNativeSourceType Other = new AXValueNativeSourceType("other");
    
    }
}