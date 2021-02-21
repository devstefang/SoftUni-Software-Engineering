using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                         .Split()
                                     .Select(int.Parse)
                                     .ToList();

            string command = "";
            while (command != "end")
            {
                command = Console.ReadLine();
                string[] cmdToArray = command.Split();
                if (cmdToArray[0] == "Delete")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    { 
                        if (numbers[i] == int.Parse(cmdToArray[1]))
                        {
                            numbers.Remove(numbers[i]);
                        }
                    }

                }
                if (cmdToArray[0] == "Insert")
                {
                    numbers.Insert(int.Parse(cmdToArray[2]), int.Parse(cmdToArray[1]));
                }
            }
            Console.WriteLine(string.Join(" ",numbers));

        }
    }
}
