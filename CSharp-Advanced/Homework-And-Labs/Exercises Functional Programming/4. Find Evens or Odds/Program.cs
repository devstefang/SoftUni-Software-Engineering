using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _4._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstNum = listNums[0];
            int lastNum = listNums[1];
            Func<int, int, List<int>> generateNums = (firstNum, lastNum) =>
            {
                List<int> numbers = new List<int>();
                for (int i = firstNum; i <= lastNum; i++)
                {
                    numbers.Add(i);
                }
                return numbers;
            };
            string condition = Console.ReadLine();
            List<int> numbers = generateNums(firstNum, lastNum);
            Func<int, bool> evenPredicate = n => n % 2 == 0;
            Func<int, bool> oddPredicate = n => n % 2 != 0;
            if (condition == "odd")
            {
                numbers = numbers.Where(oddPredicate).ToList();
            }
            else if(condition == "even")
            {
                numbers = numbers.Where(evenPredicate).ToList();

            }
            Console.WriteLine(string.Join(" ",numbers));
        }
        
    }
}
