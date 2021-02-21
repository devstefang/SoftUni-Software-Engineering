using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string parentheses = Console.ReadLine();
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>();
            int lenght = parentheses.Length / 2;
            bool isValid = true;
            
            for (int i = 0; i < lenght; i++)
            {
                stack.Push(parentheses[i].ToString());
                
            }
            for (int j = lenght  ; j < parentheses.Length; j++)
            {
                queue.Enqueue(parentheses[j].ToString());
               
            }
            queue.Reverse();
            while (stack.Count > 0 )
            {
                string current = stack.Peek();
                string secondParenthesis = queue.Peek();

                if (current == "{" )
                {
                    if (secondParenthesis == "}")
                    {
                        stack.Pop();
                        queue.Dequeue();
                 
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }
                if (current == "(")
                {
                    if (secondParenthesis == ")")
                    {
                        stack.Pop();
                        queue.Dequeue();
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }
                if (current == "[")
                {
                    if (secondParenthesis == "]")
                    {
                        stack.Pop();
                        queue.Dequeue();
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }
            }
            if (isValid == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
