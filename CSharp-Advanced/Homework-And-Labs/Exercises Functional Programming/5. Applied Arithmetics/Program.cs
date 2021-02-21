using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _5._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	"add"->add 1 to each number
            //•	          "multiply"->multiply each number by 2
            //•	        "subtract"->subtract 1 from each number
            //•         "print"->print the collection
            //•	           "end"->ends the input

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "add")
                {
                    AddToNums(numbers);
                }
                else if (command == "multiply")
                {
                    Multiply(numbers);
                }
                else if (command == "subtract")
                {
                    Subtract(numbers);
                }
                else if (command == "print")
                {
                    Print(numbers);
                }


                command = Console.ReadLine();
            }

        }
        static void AddToNums(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = numbers[i] + 1;
            }
        }
        static void Multiply(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = numbers[i] *2;
            }
        }
        static void Subtract(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = numbers[i] - 1;
            }
        }
        static void Print (List<int> numbers)
        {
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
