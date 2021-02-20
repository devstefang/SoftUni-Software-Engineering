using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();
            

            while (command != "End")
            {
                string[] cmdArgs = command.Split(" ").ToArray();
                string argument = cmdArgs[0];
                int index = int.Parse(cmdArgs[1]);
                if (argument == "Shoot")
                {
                    if (index > numbers.Count)
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    int power = int.Parse(cmdArgs[2]);
                    int currIndex = numbers[index] - power;
                    if (numbers[index] <= power)
                    {
                        numbers.Remove(numbers[index]);
                    }
                    else
                    {
                        numbers.Remove(numbers[index]);
                        numbers.Insert(index, currIndex);
                    }
                }
                else if (argument == "Add")
                {
                    int value = int.Parse(cmdArgs[2]);
                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid placement!");
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        numbers.Insert(index, value);
                    }

                   
                }
                else if (argument == "Strike")
                {
                    int radius = int.Parse(cmdArgs[2]);
                    if (index - radius <= 0 || index + radius > numbers.Count)
                    {
                        Console.WriteLine("Strike missed!");
                        command = Console.ReadLine();
                        continue;
                    }
                    for (int i = index - radius; i <= index + radius; i++)
                    {
                        numbers.RemoveAt(index - radius);
                    }

                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join('|',numbers));
        }
    }
}
