namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class InspectMode
    {
        private string m_value;

        private InspectMode(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static InspectMode SearchForNode = new InspectMode("searchForNode");
    
        public static InspectMode SearchForUAShadowDOM = new InspectMode("searchForUAShadowDOM");
    
        public static InspectMode None = new InspectMode("none");
    
    }
}