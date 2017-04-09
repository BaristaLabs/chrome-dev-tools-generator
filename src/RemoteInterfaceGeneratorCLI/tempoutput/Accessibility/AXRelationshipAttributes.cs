namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    /// <summary>
    /// Relationships between elements other than parent/child/sibling.
    /// </summary>
    public sealed class AXRelationshipAttributes
    {
        private string m_value;

        private AXRelationshipAttributes(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static AXRelationshipAttributes Activedescendant = new AXRelationshipAttributes("activedescendant");
    
        public static AXRelationshipAttributes Flowto = new AXRelationshipAttributes("flowto");
    
        public static AXRelationshipAttributes Controls = new AXRelationshipAttributes("controls");
    
        public static AXRelationshipAttributes Describedby = new AXRelationshipAttributes("describedby");
    
        public static AXRelationshipAttributes Labelledby = new AXRelationshipAttributes("labelledby");
    
        public static AXRelationshipAttributes Owns = new AXRelationshipAttributes("owns");
    
    }
}