using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            List<int> numbers = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    queue.Enqueue(arr[i]);
                }
            }
            while (queue.Count > 1)
            {
                Console.Write($"{ queue.Dequeue()}, ");
            }
            while (queue.Count > 0)
            {
                Console.Write(queue.Dequeue());
            }
        }
    }
}
