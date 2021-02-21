using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ');
                int numberCommand = int.Parse(cmdArgs[0]);
                if (numberCommand == 1)
                {
                    int number = int.Parse(cmdArgs[1]);
                    stack.Push(number);
                }
                else if (numberCommand == 2 && stack.Count > 0)
                {
                    stack.Pop();
                }
                else if (numberCommand == 3 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (numberCommand == 4 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }

            }
            Console.WriteLine(string.Join(", ",stack)); ;

        }
    }
}
