using System;
using System.Linq;

namespace FinalExam1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string command = Console.ReadLine();
            while (text != "Finish")
            {
                string[] cmdArgs = command.Split(" ");
                string action = cmdArgs[0];
                if (action == "Replace")
                {

                    text = text.Replace(cmdArgs[1], cmdArgs[2]);
                    Console.WriteLine(text);
                }
                else if (action == "Cut")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    if (startIndex > 0 && startIndex < text.Length && endIndex > 0 && endIndex < text.Length)
                    {
                        text = text.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }
                else if (action == "Make")
                {
                    string commands = cmdArgs[1];
                    if (commands == "Upper")
                    {
                        text = text.ToUpper();
                        Console.WriteLine(text);
                    }
                    else
                    {
                        text = text.ToLower();
                        Console.WriteLine(text);
                    }
                }
                else if (action == "Check")
                {
                    string substring = cmdArgs[1];
                    if (text.Contains(substring))
                    {
                        Console.WriteLine($"Message contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesnt't contain {substring}");
                    }
                }
                else if (action == "Sum")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    if (startIndex > 0 && startIndex < text.Length && endIndex > 0 && endIndex < text.Length)
                    {
                        string stringToSum = text.Substring(startIndex, endIndex - startIndex);
                        int sum = 0;
                        foreach (var chars in stringToSum)
                        {
                            sum += chars;
                        }
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices");
                    }

                }







                command = Console.ReadLine();
            }


        }
    }
}
