namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    /// <summary>
    /// Scope description.
    /// </summary>
    public sealed class Scope
    {
    
        /// <summary>
        /// Scope type.
        ///</summary>
        public string Type
        {
            get;
            set;
        }
    
        /// <summary>
        /// Object representing the scope. For <code>global</code> and <code>with</code> scopes it represents the actual object; for the rest of the scopes, it is artificial transient object enumerating scope variables as its properties.
        ///</summary>
        public BaristaLabs.ChromeDevTools.Runtime.Runtime.RemoteObject Object
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        public string Name
        {
            get;
            set;
        }
    
        /// <summary>
        /// Location in the source code where scope starts
        ///</summary>
        public Location StartLocation
        {
            get;
            set;
        }
    
        /// <summary>
        /// Location in the source code where scope ends
        ///</summary>
        public Location EndLocation
        {
            get;
            set;
        }
    
    }
}