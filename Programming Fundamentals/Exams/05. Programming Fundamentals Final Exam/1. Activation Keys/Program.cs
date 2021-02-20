using System;
using System.Linq;

namespace _1._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            // check if digit or letter

            string key = Console.ReadLine();

            string commands = Console.ReadLine();
            while (commands != "Generate")
            {
                string[] cmdArgs = commands.Split(">>>");
                string action = cmdArgs[0];
                if (action == "Contains")
                {
                    string substring = cmdArgs[1];
                    if (key.Contains(substring))
                    {
                        Console.WriteLine($"{key} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (action == "Flip")
                {
                    string token = cmdArgs[1];
                    int startIndex = int.Parse(cmdArgs[2]);
                    int endIndex = int.Parse(cmdArgs[3]);
                    if (token == "Upper")
                    {
                        string stringToManipulate = key.Substring(startIndex, endIndex - startIndex);
                        string changedString = stringToManipulate.ToUpper();
                        key = key.Remove(startIndex, endIndex - startIndex);
                        key = key.Insert(startIndex, changedString);
                        Console.WriteLine(key);
                    }
                    else
                    {
                        string stringToManipulate = key.Substring(startIndex, endIndex - startIndex);
                        string changedString = stringToManipulate.ToLower();
                        key = key.Remove(startIndex, endIndex - startIndex);
                        key = key.Insert(startIndex, changedString);
                        Console.WriteLine(key);
                    }

                }
                else if (action == "Slice")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    key = key.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(key);

                }






                commands = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {key}");

        }
    }
}
