using System;
using System.Linq;
using System.Collections.Generic;
namespace _02.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split("!").ToList();

            string command = Console.ReadLine();
            string[] cmdArgs = command.Split(' ').ToArray();
            string argument = cmdArgs[0];
            while (command != "Go Shopping!")
            {
                if (!shoppingList.Contains(cmdArgs[1]))
                {
                    if (argument == "Urgent")
                    {
                        int index = 0;
                        shoppingList.Insert(index,cmdArgs[1]);
                    }
                   
                    
                }
                else
                {
                    if (argument == "Rearrange")
                    {
                        string item = cmdArgs[1];
                        shoppingList.Remove(item);
                        shoppingList.Add(item);
                    }
                    if (argument == "Unnecessary")
                    {
                        shoppingList.Remove(cmdArgs[1]);
                    }

                    if (argument == "Correct")
                    {
                        shoppingList[shoppingList.FindIndex(ind => ind.Equals(cmdArgs[1]))] = cmdArgs[2];
                    }
                }

                command = Console.ReadLine();
                cmdArgs = command.Split(" ").ToArray();
                argument = cmdArgs[0];
            }

            Console.WriteLine(string.Join(", ",shoppingList));

        }
    }
}
