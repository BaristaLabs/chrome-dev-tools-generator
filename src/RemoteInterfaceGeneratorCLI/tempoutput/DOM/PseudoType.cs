namespace BaristaLabs.ChromeDevTools.Runtime.DOM
{
    /// <summary>
    /// Pseudo element type.
    /// </summary>
    public sealed class PseudoType
    {
        private string m_value;

        private PseudoType(string value)
        {
            m_value = value;
        }

        public override string ToString()
        {
            return m_value;
        }

    
        public static PseudoType FirstLine = new PseudoType("first-line");
    
        public static PseudoType FirstLetter = new PseudoType("first-letter");
    
        public static PseudoType Before = new PseudoType("before");
    
        public static PseudoType After = new PseudoType("after");
    
        public static PseudoType Backdrop = new PseudoType("backdrop");
    
        public static PseudoType Selection = new PseudoType("selection");
    
        public static PseudoType FirstLineInherited = new PseudoType("first-line-inherited");
    
        public static PseudoType Scrollbar = new PseudoType("scrollbar");
    
        public static PseudoType ScrollbarThumb = new PseudoType("scrollbar-thumb");
    
        public static PseudoType ScrollbarButton = new PseudoType("scrollbar-button");
    
        public static PseudoType ScrollbarTrack = new PseudoType("scrollbar-track");
    
        public static PseudoType ScrollbarTrackPiece = new PseudoType("scrollbar-track-piece");
    
        public static PseudoType ScrollbarCorner = new PseudoType("scrollbar-corner");
    
        public static PseudoType Resizer = new PseudoType("resizer");
    
        public static PseudoType InputListButton = new PseudoType("input-list-button");
    
    }
}