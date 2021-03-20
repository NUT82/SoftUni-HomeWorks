using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern.Core.Factories
{
    public class CommandFactory : ICommandFactory
    {
        public ICommand CreateCommand(string command)
        {
            var type = Assembly.GetEntryAssembly().GetTypes().Where(t => t.Name.StartsWith(command)).FirstOrDefault();

            if (type == null)
            {
                throw new ArgumentException($"{command} command do's not exist!");
            }

            return (ICommand)Activator.CreateInstance(type);
        }
    }
}
