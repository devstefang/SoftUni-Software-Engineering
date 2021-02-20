using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._List_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> friendNames = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            string[] cmdArgs = input.Split();
            bool isNotvalid = (cmdArgs[0] == "Error" || cmdArgs[0] == "Change") && (int.Parse(cmdArgs[1]) < 0 || int.Parse(cmdArgs[1]) >= friendNames.Count);
            int blackListCount = 0;
            int lostCount = 0;
            string commands = cmdArgs[0];
            while (input != "Report")
            {
                if (isNotvalid)
                {
                    input = Console.ReadLine();
                    cmdArgs = input.Split();
                    commands = cmdArgs[0];
                    continue;
                }
                if (commands == "Blacklist" && friendNames.Contains(cmdArgs[1]))
                {
                    int index = friendNames.IndexOf(cmdArgs[1]);
                    Console.WriteLine($"{friendNames[index]} was blacklisted.");
                    friendNames.Remove(cmdArgs[1]);
                    friendNames.Insert(index, "Blacklisted");
                    blackListCount++;


                }
                else if (commands == "Blacklist")
                {
                    Console.WriteLine($"{cmdArgs[1]} was not found.");
                }

                else if (commands == "Error")
                {
                    int indexForError = int.Parse(cmdArgs[1]);
                    if (friendNames[indexForError] == "Blacklisted" || friendNames[indexForError] == "Lost")
                    {
                        input = Console.ReadLine();
                        cmdArgs = input.Split();
                        commands = cmdArgs[0];
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{friendNames[indexForError]} was lost due to an error.");
                        int index = friendNames.IndexOf(friendNames[indexForError]);
                        friendNames.Remove(friendNames[indexForError]);
                        friendNames.Insert(index, "Lost");
                        lostCount++;
                    }


                }

                else if (commands == "Change")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index >= 0 && index < friendNames.Count)
                    {
                        string newName = cmdArgs[2];
                        Console.WriteLine($"{friendNames[index]} changed his username to {newName}.");
                        int indexOfName = friendNames.IndexOf(friendNames[index]);
                        friendNames.Remove(friendNames[indexOfName]);
                        friendNames.Insert(indexOfName, newName);
                    }

                }
                input = Console.ReadLine();
                cmdArgs = input.Split();
                commands = cmdArgs[0];
            }

            Console.WriteLine($"Blacklisted names: {blackListCount}");
            Console.WriteLine($"Lost names: {lostCount}");
            Console.WriteLine(string.Join(" ", friendNames));
        }
    }
}
