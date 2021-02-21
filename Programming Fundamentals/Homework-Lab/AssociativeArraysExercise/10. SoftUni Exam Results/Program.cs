using System;
using System.Collections.Generic;
using System.Linq;
namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string[] cmdArgs = command.Split("-");
            Dictionary<string, int> examResults = new Dictionary<string, int>();
            Dictionary<string, int> languageCounts = new Dictionary<string, int>();
            while (command != "exam finished")
            {
                string username = cmdArgs[0];
                string language = cmdArgs[1];
                if (cmdArgs[1] == "banned")
                {
                    examResults.Remove(cmdArgs[0]);
                    break;
                }
                if (examResults.ContainsKey(username))
                {
                    examResults[username] = int.Parse(cmdArgs[2]);
                    command = Console.ReadLine();
                    cmdArgs = command.Split("-");
                    languageCounts[language]++;
                    continue;
                }
                examResults.Add(username, int.Parse(cmdArgs[2]));
                if (!languageCounts.ContainsKey(language))
                {
                    languageCounts.Add(language, 0);
                }
                languageCounts[language]++;
               
                command = Console.ReadLine();
                cmdArgs = command.Split("-");
                
            }
            Console.WriteLine("Results:");
            foreach (var item in examResults.OrderByDescending(x=>x.Value).ThenBy(x => x.Key))
            {
                
                Console.WriteLine(string.Join(" | ",item.Key,item.Value));

            }
            Console.WriteLine("Submissions:");
            foreach (var items in languageCounts.OrderByDescending(x=>x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine(string.Join(" - ",items.Key,items.Value));
            }
        }





    }
}
