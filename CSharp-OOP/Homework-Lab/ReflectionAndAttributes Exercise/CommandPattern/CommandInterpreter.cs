using CommandPattern.Commands;
using CommandPattern.Core;
using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] tokens = args.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            string commandName = tokens[0];
            string[] commandArgs = tokens.Skip(1).ToArray();

            string result = string.Empty;
            Type type = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == $"{commandName}Command");
            
            ICommand instance = (ICommand)Activator.CreateInstance(type);
                result = instance?.Execute(commandArgs) ?? "Invalid command";
            return result;

        }
    }
}
