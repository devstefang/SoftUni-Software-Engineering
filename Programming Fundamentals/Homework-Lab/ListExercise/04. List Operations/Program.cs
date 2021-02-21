using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                          .Split()
                                      .Select(int.Parse)
                                      .ToList();

            string command = Console.ReadLine();


            while (command != "End")
            {
                string[] listOfCommands = command.Split(" ");
                if (listOfCommands[0] == "Add")
                {
                    numbers.Add(int.Parse(listOfCommands[1]));
                }
                if (listOfCommands[0] == "Remove")
                {
                    numbers.Remove(int.Parse(listOfCommands[1]));
                }
                
                if (listOfCommands[0] == "Shift")
                {
                    int rotation = int.Parse(listOfCommands[2]);
                    if (listOfCommands[1].ToString() == "left")
                    {
                        for (int i = 0; i < rotation; i++)
                        {
                            int firstElement = numbers[0]; 
                            for (int j = 0; j < numbers.Count - 1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                            }
                            numbers[numbers.Count - 1] = firstElement;
                        }

                    }
                    else
                    {
                        for (int i = 0; i < rotation; i++)
                        {
                            int lastNumber = numbers[numbers.Count - 1];
                            for (int j = numbers.Count; i > 0; j--)
                            {
                                numbers[j] = numbers[j - 1];
                            }
                            numbers[0] = lastNumber;
                        }
                    }
                   

                }
                if (listOfCommands[0] == "Insert")
                {
                    numbers.Insert(int.Parse(listOfCommands[2]),int.Parse(listOfCommands[1]));
                }
                //arr = numbers.ToArray();
                command = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", numbers));



        }

     



    }
    
}
