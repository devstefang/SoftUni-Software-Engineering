﻿using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CommandPattern.Core
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;
        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }
        public void Run()
        {
            while (true)
            {
                string input = Console.ReadLine();
                var result = commandInterpreter.Read(input);
                Console.WriteLine(result);
            }
        }
    }
}
