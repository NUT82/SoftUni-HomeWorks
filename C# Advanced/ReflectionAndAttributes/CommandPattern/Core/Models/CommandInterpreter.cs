using CommandPattern.Core.Contracts;
using CommandPattern.Core.Factories;
using System.Linq;

namespace CommandPattern.Core.Models
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] splitArgs = args.Split();

            string currCommand = splitArgs[0];
            string[] currArgs = splitArgs.Skip(1).ToArray();

            ICommandFactory commandFactory = new CommandFactory();
            ICommand commanand = commandFactory.CreateCommand(currCommand);
            return commanand.Execute(currArgs);
        }
    }
}
