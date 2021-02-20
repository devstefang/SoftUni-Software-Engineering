using System;
using System.Linq;
namespace _05.TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] topNumbers = Console.ReadLine()
                                        .Split(" ")
                                        .Select(int.Parse)
                                        .ToArray();
            for (int i = 0; i < topNumbers.Length; i++)
            {
                if (topNumbers[i] > topNumbers[i + 1 ])
                {
                    Console.Write(string.Join(" ", topNumbers));
                }
            }

            
        }
    }
}
