using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _6._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int divideBy = int.Parse(Console.ReadLine());
            numbers.Reverse();
            Func<int, bool> predicate = n => n % divideBy != 0;
           numbers = numbers.Where(predicate).ToList();
            Console.WriteLine(string.Join(" ",numbers));

        }
    }
}
