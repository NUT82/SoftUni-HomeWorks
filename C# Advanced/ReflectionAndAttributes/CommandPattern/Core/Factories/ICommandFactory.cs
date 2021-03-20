using CommandPattern.Core.Contracts;

namespace CommandPattern.Core.Factories
{
    public interface ICommandFactory
    {
        ICommand CreateCommand(string command);
    }
}
