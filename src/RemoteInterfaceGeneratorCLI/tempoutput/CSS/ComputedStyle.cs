namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    /// <summary>
    /// A subset of the full ComputedStyle as defined by the request whitelist.
    /// </summary>
    public sealed class ComputedStyle
    {
    
        /// <summary>
        /// 
        ///</summary>
        public CSSComputedStyleProperty[] Properties
        {
            get;
            set;
        }
    
    }
}