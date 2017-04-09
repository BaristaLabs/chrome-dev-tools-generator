namespace BaristaLabs.ChromeDevTools.Runtime.CSS
{
    /// <summary>
    /// Details of post layout rendered text positions. The exact layout should not be regarded as stable and may change between versions.
    /// </summary>
    public sealed class InlineTextBox
    {
    
        /// <summary>
        /// The absolute position bounding box.
        ///</summary>
        public BaristaLabs.ChromeDevTools.Runtime.DOM.Rect BoundingBox
        {
            get;
            set;
        }
    
        /// <summary>
        /// The starting index in characters, for this post layout textbox substring.
        ///</summary>
        public long StartCharacterIndex
        {
            get;
            set;
        }
    
        /// <summary>
        /// The number of characters in this post layout textbox substring.
        ///</summary>
        public long NumCharacters
        {
            get;
            set;
        }
    
    }
}