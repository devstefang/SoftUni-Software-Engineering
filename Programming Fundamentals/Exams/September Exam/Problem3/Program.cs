using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
            string command = Console.ReadLine();
            var sortedDict = new SortedDictionary<string, List<int>>();
            while (command != "Log out")
            {
                string[] cmdArgs = command.Split(':');
                string action = cmdArgs[0];
                string username = cmdArgs[1];
                if (action == "New follower")
                {
                    if (!dict.ContainsKey(username))
                    {
                        dict.Add(username, new List<int> { 0, 0 });
                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (action == "Like")
                {
                    int likes = int.Parse(cmdArgs[2]);
                    if (!dict.ContainsKey(username))
                    {
                        dict.Add(username, new List<int> { likes, 0 });

                    }
                    else
                    {
                        dict[username][0] += likes;
                    }
                }
                else if (action == "Comment")
                {
                    if (!dict.ContainsKey(username))
                    {
                        dict.Add(username, new List<int> { 0, 1 });
                    }
                    else
                    {
                        dict[username][1] += 1;
                    }
                }
                else if (action == "Blocked")
                {
                    if (dict.ContainsKey(username))
                    {
                        dict.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                }





                command = Console.ReadLine();
            }
            Console.WriteLine($"{dict.Count} followers");
                
            foreach (var followers in dict.OrderByDescending(x=> x.Value[0] + x.Value[1]).ThenBy(x=>x.Key))
            {
                int sum = followers.Value[0] + followers.Value[1];
                Console.WriteLine($"{followers.Key}: {sum}");




            }


        }
    }
}
