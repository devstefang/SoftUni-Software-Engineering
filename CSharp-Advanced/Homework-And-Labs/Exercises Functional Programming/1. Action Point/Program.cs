using System;
using System.IO;

namespace _1._Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Action<string[]> printNames = a => Console.WriteLine(string.Join(Environment.NewLine,names));
            printNames(names);
        }
    }
}
