using System;
using System.Collections.Generic;
using System.IO;

namespace IteratorsAndComparators
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<string> list = new List<string>();
            Iterators<string> listyIterator = new Iterators<string>(list);
            while (command != "END")
            {
                string[] cmdArgs = command.Split();
                string action = cmdArgs[0];
                if (action == "Create")
                {
                    for (int i = 1; i < cmdArgs.Length; i++)
                    {
                        list.Add(cmdArgs[i]);
                    }
                    listyIterator.Create(list);
                }
                else if (action == "Move")
                {
                    Console.WriteLine(listyIterator.Move());
                }
                else if (action == "HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext());
                }
                else if ( action == "Print")
                {
                    listyIterator.Print();
                }
                else if (action == "PrintAll")
                {
                    foreach (var item in listyIterator)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
                command = Console.ReadLine();
            }
        }
    }
}
