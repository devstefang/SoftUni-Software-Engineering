using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> invitedPeople = Console.ReadLine().Split().ToList();
            string command;

            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] cmdArgs = command.Split();
                string action = cmdArgs[0];
                var predicate = GetPredicate(cmdArgs[1], cmdArgs[2]);
                if (action == "Remove")
                {
                    invitedPeople.RemoveAll(predicate);
                }
                else if (action == "Double")
                {
                    var matches = invitedPeople.FindAll(predicate);
                    if (matches.Count > 0)
                    {
                        int index = invitedPeople.FindIndex(predicate);
                        invitedPeople.InsertRange(index, matches);
                    }

                }
            }
            if (invitedPeople.Count > 0)
            {
                Console.WriteLine($"{ string.Join(", ", invitedPeople)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        static Predicate<string> GetPredicate(string command, string argument)
        {
            if (command == "StartsWith")
            {
                return n => n.StartsWith(argument);
            }
            else if (command == "EndsWith")
            {
                return n => n.EndsWith(argument);
            }
            else if (command == "Length")
            {
                return n => n.Length == int.Parse(argument);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
