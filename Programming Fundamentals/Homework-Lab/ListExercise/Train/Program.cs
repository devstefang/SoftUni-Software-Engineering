using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagonCurrent = Console.ReadLine()
                                        .Split()
                                    .Select(int.Parse)
                                    .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandToArray = command.Split();
                if (commandToArray[0] == "Add")
                {
                    wagonCurrent.Add(int.Parse(commandToArray[1]));
                }
                else
                {
                    int passengers = int.Parse(commandToArray[0]);
                    for (int i = 0; i < wagonCurrent.Count; i++)
                    {
                        int addingPassengers = wagonCurrent[i];
                        
                        if (addingPassengers + passengers <= maxCapacity)
                        {
                            wagonCurrent[i] += passengers;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",wagonCurrent));
        }
    }
}
