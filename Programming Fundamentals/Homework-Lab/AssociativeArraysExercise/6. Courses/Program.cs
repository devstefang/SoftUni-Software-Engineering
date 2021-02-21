using System;
using System.Collections.Generic;
using System.Linq;
namespace _6._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cmdArgs = Console.ReadLine().Split(" : ");
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string coursename = cmdArgs[0];
            while (cmdArgs[0] != "end")
            {
                 coursename = cmdArgs[0];
                string name = cmdArgs[1];
                if (!courses.ContainsKey(coursename))
                {
                    courses.Add(coursename, new List<string>());
                }
                courses[coursename].Add(name);

                cmdArgs = Console.ReadLine().Split(" : ");
            }

            foreach (var item in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                foreach (var items in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {items}");
                }
            }
        }
    }
}
