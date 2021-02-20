using System;
using System.Collections.Generic;
using System.IO;

namespace _5.ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string information;
            List<Person> persons = new List<Person>();
            while ((information = Console.ReadLine()) != "END")
            {
                string[] splittedInfo = information.Split();
                string name = splittedInfo[0];
                int age = int.Parse(splittedInfo[1]);
                string town = splittedInfo[2];
                Person newPerson = new Person(name, age, town);
                persons.Add(newPerson);
            }
            int n = int.Parse(Console.ReadLine());
            Person comparePerson = persons[n-1];
            int samePersonCount = 0;
            foreach (var person in persons)
            {
                if (person.CompareTo(comparePerson) == 0)
                {
                    samePersonCount++;
                }
            }
            if (samePersonCount == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int notSamePersonCount = persons.Count - samePersonCount;
                Console.WriteLine($"{samePersonCount} {notSamePersonCount} {persons.Count}");
            }
        }
    }
}
