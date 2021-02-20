using System;
using System.Text.RegularExpressions;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"U\$([A-Z][a-z]{2,})U\$P@\$([A-z]{5,}\d+)P@\$";
            int n = int.Parse(Console.ReadLine());
            Regex regex = new Regex(pattern);
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    Console.WriteLine("Registration was successful");
                    string username = match.Groups[1].Value;
                    string password = match.Groups[2].Value;
                    Console.WriteLine($"Username: {username}, Password: {password}");
                    count++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }

            }

            Console.WriteLine($"Successful registrations: {count}");
        }
    }
}
