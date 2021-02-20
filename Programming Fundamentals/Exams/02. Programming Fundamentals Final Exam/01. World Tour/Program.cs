using System;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string destinations = Console.ReadLine();
            string commands = Console.ReadLine();
            while ( commands != "Travel")
            {
                string[] cmdArgs = commands.Split(":");
                string singlecommand = cmdArgs[0];
                if (singlecommand == "Add Stop" && int.Parse(cmdArgs[1]) >=0 && int.Parse(cmdArgs[1]) < destinations.Length)
                {
                    int index = int.Parse(cmdArgs[1]);

                   destinations = destinations.Insert(index, cmdArgs[2]);
                    

                }
                if (singlecommand == "Remove Stop" && int.Parse(cmdArgs[1]) >= 0 && int.Parse(cmdArgs[1]) < destinations.Length && int.Parse(cmdArgs[2]) >= int.Parse(cmdArgs[1]) && int.Parse(cmdArgs[2]) < destinations.Length)
                {
                    // Check indexes if it breaks
                   destinations = destinations.Remove(int.Parse(cmdArgs[1]), (int.Parse(cmdArgs[2]) - int.Parse(cmdArgs[1]) + 1));
                    
                }
                 if (singlecommand == "Switch" && destinations.Contains(cmdArgs[1]))
                {
                    destinations = destinations.Replace(cmdArgs[1], cmdArgs[2]);
                    
                }
                Console.WriteLine(destinations);

                commands = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {destinations}");


        }
    }
}
