using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int loopNumbers = intArgs[0];
            int dequeueCount = intArgs[1];
            int numberToLook = intArgs[2];
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers);
            for (int i = 0; i < dequeueCount; i++)
            {
                queue.Dequeue();   
            }
            if (queue.Contains(numberToLook))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count <= 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }


        }
    }
}
