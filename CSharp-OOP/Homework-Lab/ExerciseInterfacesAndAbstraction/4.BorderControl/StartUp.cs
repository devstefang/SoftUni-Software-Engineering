using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.BorderControl
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            string command;
            List<IIdentifiable> list = new List<IIdentifiable>();
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split();
                if (cmdArgs.Length == 3)
                {
                    string name = cmdArgs[0];
                    int age = int.Parse(cmdArgs[1]);
                    string id = cmdArgs[2];
                    Citizen citizen = new Citizen(name, age, id);
                    list.Add(citizen);
                }
                else if (cmdArgs.Length == 2)
                {
                    string model = cmdArgs[0];
                    string id = cmdArgs[1];
                    Robot robot = new Robot(model, id);
                    list.Add(robot);
                }
            }
            string idCheck = Console.ReadLine();
            list.Where(c => c.Id.EndsWith(idCheck))
                .Select(c => c.Id)
                .ToList()
                .ForEach(Console.WriteLine);
        }
            



    }
}
