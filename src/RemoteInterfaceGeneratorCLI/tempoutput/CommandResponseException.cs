namespace BaristaLabs.ChromeDevTools.Runtime
{
    using System;

    [Serializable]
    public class CommandResponseException : Exception
    {
        public long Code
        {
            get;
            set;
        }

        public CommandResponseException()
        {
        }

        public CommandResponseException(string message)
            : base(message)
        {
        }

        public CommandResponseException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}