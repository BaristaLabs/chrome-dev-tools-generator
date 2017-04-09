namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class ShorthandEntry
    {
    
        /// <summary>
        /// Shorthand name.
        ///</summary>
        public string Name
        {
            get;
            set;
        }
    
        /// <summary>
        /// Shorthand value.
        ///</summary>
        public string Value
        {
            get;
            set;
        }
    
        /// <summary>
        /// Whether the property has "!important" annotation (implies <code>false</code> if absent).
        ///</summary>
        public bool Important
        {
            get;
            set;
        }
    
    }
}