using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _7._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLenght = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            Func<string, bool> predicate = n => n.Length <= nameLenght;
            names = names.Where(predicate).ToList();
            Console.WriteLine(string.Join(Environment.NewLine,names));
        }
    }
}
