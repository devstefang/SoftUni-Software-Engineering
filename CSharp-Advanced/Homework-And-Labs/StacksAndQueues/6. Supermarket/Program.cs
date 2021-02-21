using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            string input = Console.ReadLine();
            int count = 0;

            while (input != "End")
            {
                if (input == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                    count = 0;
                }
                else
                {
                    queue.Enqueue(input);
                    count++;
                }

                
                input = Console.ReadLine();
            }
            Console.WriteLine($"{count} people remaining.");

        }
    }
}
