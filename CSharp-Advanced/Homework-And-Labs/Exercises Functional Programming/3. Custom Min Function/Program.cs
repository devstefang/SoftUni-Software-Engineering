using System;
using System.IO;
using System.Linq;

namespace _3._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> func = nums =>
            {
                int minNum = numbers.Min();
               
                return minNum;
            };
            Console.WriteLine(func(numbers));



        }
    }
}
