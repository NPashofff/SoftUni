namespace CommandPattern.Core.Models
{
    using Commands;
    using Core.Contracts;
    using System;
    using System.Linq;
    using System.Reflection;

    public class CommandInterpreter : ICommandInterpreter

    {
        public string Read(string args)
        {
            string[] tockens = args.Split();
            string commandName = tockens[0];
            string[] commandArgs = tockens[1..];

            Type commandType = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == $"{commandName}Command");
            ICommand command = (ICommand)Activator.CreateInstance(commandType);

            string result = command.Execute(commandArgs);
            return result;
        }
    }
}
