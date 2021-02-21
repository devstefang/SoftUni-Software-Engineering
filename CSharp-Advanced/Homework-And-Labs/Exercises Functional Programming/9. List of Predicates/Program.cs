using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _9._List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            List<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 1; i <= lenght; i++)
            {
                if (DividerCheck(i,dividers))
                {
                    numbers.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ",numbers));



        }
       static bool DividerCheck(int n ,List<int> dividers)
        {
            bool isDivisible = true;
            foreach (var divider in dividers)
            {
                if (n % divider != 0)
                {
                    isDivisible = false;
                }
            }
            return isDivisible;
        }
    }
}
