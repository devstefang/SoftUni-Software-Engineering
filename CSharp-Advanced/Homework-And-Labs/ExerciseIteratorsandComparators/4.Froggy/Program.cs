using System;
using System.IO;
using System.Linq;

namespace _4.Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stones = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Lake lake = new Lake(stones.ToList());
            Console.WriteLine(string.Join(", ",lake));

        }
    }
}
