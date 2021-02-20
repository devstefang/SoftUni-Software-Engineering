using System;
using System.Collections.Generic;
using System.IO;

namespace _6.EqualityLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string information;
            SortedSet<Person> sortedSet = new SortedSet<Person>();
            HashSet<Person> hashSet = new HashSet<Person>();
            for (int i = 0; i < n; i++)
            {
                information = Console.ReadLine();
                string[] splittedInfo = information.Split();
                string name = splittedInfo[0];
                int age = int.Parse(splittedInfo[1]);
                Person newPerson = new Person(name, age);
                hashSet.Add(newPerson);
                sortedSet.Add(newPerson);
            }
            Console.WriteLine(hashSet.Count);
            Console.WriteLine(sortedSet.Count);
        }
    }
}
