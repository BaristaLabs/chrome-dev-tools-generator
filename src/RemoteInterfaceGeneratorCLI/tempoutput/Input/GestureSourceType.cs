namespace BaristaLabs.ChromeDevTools.Runtime.Input
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class GestureSourceType
    {
        private string m_value;

        private GestureSourceType(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static GestureSourceType Default = new GestureSourceType("default");
    
        public static GestureSourceType Touch = new GestureSourceType("touch");
    
        public static GestureSourceType Mouse = new GestureSourceType("mouse");
    
    }
}