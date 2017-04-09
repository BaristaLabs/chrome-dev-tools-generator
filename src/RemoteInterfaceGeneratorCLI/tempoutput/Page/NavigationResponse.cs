namespace BaristaLabs.ChromeDevTools.Runtime.Page
{
    /// <summary>
    /// Proceed: allow the navigation; Cancel: cancel the navigation; CancelAndIgnore: cancels the navigation and makes the requester of the navigation acts like the request was never made.
    /// </summary>
    public sealed class NavigationResponse
    {
        private string m_value;

        private NavigationResponse(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static NavigationResponse Proceed = new NavigationResponse("Proceed");
    
        public static NavigationResponse Cancel = new NavigationResponse("Cancel");
    
        public static NavigationResponse CancelAndIgnore = new NavigationResponse("CancelAndIgnore");
    
    }
}