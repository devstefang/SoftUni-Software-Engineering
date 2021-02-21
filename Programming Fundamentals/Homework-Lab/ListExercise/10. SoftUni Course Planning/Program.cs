using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfCommands = Console.ReadLine()
                                       .Split(",")
                                   .ToList();
            string command = Console.ReadLine();
            string[] cmdArr = command.Split(":").ToArray();
            while (command != "course start")
            {
                string lessonTitle = cmdArr[1];
                if (lessonTitle != )
                {

                }
                if (cmdArr[0] == "Add")
                {
                    listOfCommands.Add(cmdArr[1]);
                }
                else if (cmdArr[0] == "Insert")
                {
                    listOfCommands.Insert(int.Parse(cmdArr[2]), cmdArr[1]);
                }
                else if (cmdArr[0] == "Remove")
                {
                    listOfCommands.Remove(cmdArr[1]);
                }
                else if (cmdArr[0] == "Swap")
                {
                    string secondLesson = cmdArr[2];
                    string firstLesson = cmdArr[1];
                    int indexOfFirst = listOfCommands.IndexOf(firstLesson);
                    int indexOfSecond = listOfCommands.IndexOf(secondLesson);
                    if (indexOfFirst != -1 && indexOfSecond != -1)
                    {
                        listOfCommands[indexOfFirst] = secondLesson;
                        listOfCommands[indexOfSecond] = firstLesson;
                    }


                }
                else if (cmdArr[0] == "Exercise")
                {

                }

                

                 command = Console.ReadLine();
                cmdArr = command.Split(":").ToArray();
            }

            Console.WriteLine(string.Join($"",listOfCommands));



        }
        
    }
}
