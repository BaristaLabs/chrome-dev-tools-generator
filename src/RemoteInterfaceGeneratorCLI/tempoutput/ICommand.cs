namespace BaristaLabs.ChromeDevTools.Runtime
{
    /// <summary>
    /// Represents a command used by the Chrome Remote Interface
    ///</summary>
    public interface ICommand<T>
        where T : ICommandResponse
    {
        /// <summary>
        /// Gets the name of the command.
        /// </summary>
        string CommandName
        {
            get;
        }
    }

    public interface ICommandResponse
    {
    }
}