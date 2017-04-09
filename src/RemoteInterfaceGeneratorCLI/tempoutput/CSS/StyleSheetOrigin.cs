namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    /// <summary>
    /// Stylesheet type: "injected" for stylesheets injected via extension, "user-agent" for user-agent stylesheets, "inspector" for stylesheets created by the inspector (i.e. those holding the "via inspector" rules), "regular" for regular stylesheets.
    /// </summary>
    public sealed class StyleSheetOrigin
    {
        private string m_value;

        private StyleSheetOrigin(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static StyleSheetOrigin Injected = new StyleSheetOrigin("injected");
    
        public static StyleSheetOrigin UserAgent = new StyleSheetOrigin("user-agent");
    
        public static StyleSheetOrigin Inspector = new StyleSheetOrigin("inspector");
    
        public static StyleSheetOrigin Regular = new StyleSheetOrigin("regular");
    
    }
}