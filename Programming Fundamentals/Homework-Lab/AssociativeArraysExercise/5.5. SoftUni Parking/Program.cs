using System;
using System.Collections.Generic;
using System.Linq;
namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = "";
            string[] cmdArgs = { };
            Dictionary<string, string> parking = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine();
                cmdArgs = command.Split();

                string username = cmdArgs[1];


                if (cmdArgs[0] == "register")
                {

                    string licensePlate = cmdArgs[2];
                    if (!parking.ContainsKey(username))
                    {
                        parking.Add(username, licensePlate);
                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                }
                else if (cmdArgs[0] == "unregister")
                {
                    if (!parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        parking.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }
            foreach (var w in parking)
            {
                Console.WriteLine($"{w.Key} => {w.Value}");
            }




        }
    }
}
