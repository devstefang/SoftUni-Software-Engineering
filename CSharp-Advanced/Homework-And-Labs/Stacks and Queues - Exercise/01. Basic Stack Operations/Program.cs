using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int loopCount = numberArgs[0];
            int popCount = numberArgs[1];
            int presentNumber  = numberArgs[2];
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < loopCount; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < popCount; i++)
            {
                stack.Pop();
            }
            if (stack.Count <= 0)
            {
                Console.WriteLine("0");
                
            }
            else if (stack.Contains(presentNumber))
            {
                Console.WriteLine("true");
            }
            else if(!stack.Contains(presentNumber))
            {
                Console.WriteLine(stack.Min());
            }

        }
    }
}
