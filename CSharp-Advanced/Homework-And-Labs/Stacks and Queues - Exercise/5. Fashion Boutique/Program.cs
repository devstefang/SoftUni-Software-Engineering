using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(clothes);
            int rackCount = 1;
            int sum = 0;

            while(stack.Count > 0)
            {
                
                var current = stack.Peek();
                if (sum + current >= capacity )
                {
                    sum = 0;
                    rackCount++;
                }
                else
                {
                    sum += stack.Pop();
                }
            }
            Console.WriteLine(rackCount);




        }
    }
}
