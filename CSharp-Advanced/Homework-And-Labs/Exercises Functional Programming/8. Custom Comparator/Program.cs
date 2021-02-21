using System;
using System.IO;
using System.Linq;

namespace _8._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(numbers, (x, y) => (x % 2 == 0 && y % 2 != 0) ? -1 :
             (x % 2 != 0 && y % 2 == 0) ? 1 :
             (x.CompareTo(y)));

            Console.WriteLine(String.Join(" ",numbers));

        }
    }
}
