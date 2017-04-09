namespace BaristaLabs.ChromeDevTools.Runtime.Debugger
{
    /// <summary>
    /// JavaScript call frame. Array of call frames form the call stack.
    /// </summary>
    public sealed class CallFrame
    {
    
        /// <summary>
        /// Call frame identifier. This identifier is only valid while the virtual machine is paused.
        ///</summary>
        public string CallFrameId
        {
            get;
            set;
        }
    
        /// <summary>
        /// Name of the JavaScript function called on this call frame.
        ///</summary>
        public string FunctionName
        {
            get;
            set;
        }
    
        /// <summary>
        /// Location in the source code.
        ///</summary>
        public Location FunctionLocation
        {
            get;
            set;
        }
    
        /// <summary>
        /// Location in the source code.
        ///</summary>
        public Location Location
        {
            get;
            set;
        }
    
        /// <summary>
        /// Scope chain for this call frame.
        ///</summary>
        public Scope[] ScopeChain
        {
            get;
            set;
        }
    
        /// <summary>
        /// <code>this</code> object for this call frame.
        ///</summary>
        public BaristaLabs.ChromeDevTools.Runtime.Runtime.RemoteObject This
        {
            get;
            set;
        }
    
        /// <summary>
        /// The value being returned, if the function is at return point.
        ///</summary>
        public BaristaLabs.ChromeDevTools.Runtime.Runtime.RemoteObject ReturnValue
        {
            get;
            set;
        }
    
    }
}