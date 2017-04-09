namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    /// <summary>
    /// Enum of possible property types.
    /// </summary>
    public sealed class AXValueType
    {
        private string m_value;

        private AXValueType(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static AXValueType Boolean = new AXValueType("boolean");
    
        public static AXValueType Tristate = new AXValueType("tristate");
    
        public static AXValueType BooleanOrUndefined = new AXValueType("booleanOrUndefined");
    
        public static AXValueType Idref = new AXValueType("idref");
    
        public static AXValueType IdrefList = new AXValueType("idrefList");
    
        public static AXValueType Integer = new AXValueType("integer");
    
        public static AXValueType Node = new AXValueType("node");
    
        public static AXValueType NodeList = new AXValueType("nodeList");
    
        public static AXValueType Number = new AXValueType("number");
    
        public static AXValueType String = new AXValueType("string");
    
        public static AXValueType ComputedString = new AXValueType("computedString");
    
        public static AXValueType Token = new AXValueType("token");
    
        public static AXValueType TokenList = new AXValueType("tokenList");
    
        public static AXValueType DomRelation = new AXValueType("domRelation");
    
        public static AXValueType Role = new AXValueType("role");
    
        public static AXValueType InternalRole = new AXValueType("internalRole");
    
        public static AXValueType ValueUndefined = new AXValueType("valueUndefined");
    
    }
}