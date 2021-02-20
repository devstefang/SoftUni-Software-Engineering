using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string destinations = Console.ReadLine();
            string pattern = @"([=\/])([A-Z][A-Za-z]{2,})\1";
            var regex = new Regex(pattern);
            int sum = 0;
            MatchCollection match = Regex.Matches(destinations, pattern);
            List<string> finalDestinations = new List<string>();

            foreach (Match matches in match)
            {
                string destination = matches.Groups[2].Value;
                int lenght = destination.Length;
                sum += lenght;
                finalDestinations.Add(destination);
            }
            Console.WriteLine($"Destinations: {string.Join(", ",finalDestinations)}");
            Console.WriteLine($"Travel Points: {sum}");

        }

    }
}
