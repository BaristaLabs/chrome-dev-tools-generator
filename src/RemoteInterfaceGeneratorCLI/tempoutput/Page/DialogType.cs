namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    /// <summary>
    /// Javascript dialog type.
    /// </summary>
    public sealed class DialogType
    {
        private string m_value;

        private DialogType(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static DialogType Alert = new DialogType("alert");
    
        public static DialogType Confirm = new DialogType("confirm");
    
        public static DialogType Prompt = new DialogType("prompt");
    
        public static DialogType Beforeunload = new DialogType("beforeunload");
    
    }
}