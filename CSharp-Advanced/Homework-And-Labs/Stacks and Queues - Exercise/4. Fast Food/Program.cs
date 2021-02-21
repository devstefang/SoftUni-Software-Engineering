using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);
            Queue<int> printQueue = new Queue<int>(queue);
            int count = 0;
            Console.WriteLine(queue.Max());
            while (queue.Count > 0)
            {
               
                int numberToRemove = queue.Dequeue();
                
                quantityOfFood -= numberToRemove;
                if (quantityOfFood <= 0)
                {
                    break;
                }
                count++;
            }
            if (quantityOfFood >= 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    printQueue.Dequeue();
                }
                Console.WriteLine($"Orders left: {string.Join(' ', printQueue)}");
            }
           


        }
    }
}
