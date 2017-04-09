namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    /// <summary>
    /// Selector list data.
    /// </summary>
    public sealed class SelectorList
    {
    
        /// <summary>
        /// Selectors in the list.
        ///</summary>
        public Value[] Selectors
        {
            get;
            set;
        }
    
        /// <summary>
        /// Rule selector text.
        ///</summary>
        public string Text
        {
            get;
            set;
        }
    
    }
}