using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _01._Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstLootBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondLootBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(firstLootBox);
            Stack<int> stack = new Stack<int>(secondLootBox);
                        int sum = 0;
            while (true)
            {
                int currQueue = queue.Peek();
                int currStack = stack.Peek();
                int currSum = currQueue + currStack;
                if (currSum % 2 == 0 )
                {
                     sum += currStack + currQueue;
                    queue.Dequeue();
                    stack.Pop();
                }
                else
                {
                    
                    int addToQueue = stack.Pop();
                    queue.Enqueue(addToQueue);
                }
                if (queue.Count == 0 || stack.Count == 0)
                {
                    break;
                }
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }
            if (sum < 100)
            {
                Console.WriteLine($"Your loot was poor... Value: {sum}");
            }
            else if (sum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sum}");
            }
        }
    }
}
