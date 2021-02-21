using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            Func<string, int> getAsciiSum = p => p.Select(c =>(int)c).Sum();
            //string name = GetName(names, n, getAsciiSum);
            //Console.WriteLine(name);
            Func<List<string>, int, Func<string, int>, string> nameFunc = (people, n, func) => people.FirstOrDefault(p => func(p) >= n);
            string res = nameFunc(names, n, getAsciiSum);
            Console.WriteLine(res);
        }
        static string GetName(List<string> names, int n,Func<string,int> func)
        {
            string result = null;
            foreach (string person in names)
            {
                if (func(person) >= n)
                {
                    result = person;
                }
            }
            return result;
        }
    }
}
