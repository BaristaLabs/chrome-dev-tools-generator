namespace BaristaLabs.ChromeDevTools.Runtime.Network
{
    /// <summary>
    /// Represents the cookie's 'SameSite' status: https://tools.ietf.org/html/draft-west-first-party-cookies
    /// </summary>
    public sealed class CookieSameSite
    {
        private string m_value;

        private CookieSameSite(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static CookieSameSite Strict = new CookieSameSite("Strict");
    
        public static CookieSameSite Lax = new CookieSameSite("Lax");
    
    }
}