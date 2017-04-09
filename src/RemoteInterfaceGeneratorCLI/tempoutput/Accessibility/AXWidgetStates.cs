namespace BaristaLabs.ChromeDevTools.Runtime.Accessibility
{
    /// <summary>
    /// States which apply to widgets.
    /// </summary>
    public sealed class AXWidgetStates
    {
        private string m_value;

        private AXWidgetStates(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static AXWidgetStates Checked = new AXWidgetStates("checked");
    
        public static AXWidgetStates Expanded = new AXWidgetStates("expanded");
    
        public static AXWidgetStates Pressed = new AXWidgetStates("pressed");
    
        public static AXWidgetStates Selected = new AXWidgetStates("selected");
    
    }
}