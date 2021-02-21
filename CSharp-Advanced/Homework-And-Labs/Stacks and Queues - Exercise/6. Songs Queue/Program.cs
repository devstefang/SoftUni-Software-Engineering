using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songArray = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>(songArray);
            while (queue.Count > 0)
            {
                string command = Console.ReadLine();
                if (command == "Play")
                {
                    queue.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    var arr = command.Split("Add ");

                    if (queue.Contains(arr[1]))
                    {
                        Console.WriteLine($"{arr[1]} is already contained!");
                        continue;
                    }

                    queue.Enqueue(arr[1]);
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ",queue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
