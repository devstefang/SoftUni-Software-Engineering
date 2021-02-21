using System;
using System.Collections.Generic;

namespace _4._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> dict = new Dictionary<string, Dictionary<string, List<string>>>();
          
            for (int i = 0; i < n; i++)
            {  
                string[] dataToFill = Console.ReadLine().Split();
                string continent = dataToFill[0];
                string country = dataToFill[1];
                string city = dataToFill[2];
                if (!dict.ContainsKey(continent))
                {
                    dict.Add(continent, new Dictionary<string, List<string>>());
                }
                
                if (!dict[continent].ContainsKey(country))
                {
                    dict[continent].Add(country, new List<string>());
                }
                    dict[continent][country].Add(city);
                
            }
            foreach (var continents in dict.Keys)
            {
                Console.WriteLine($"{continents}:");
                foreach (var kvp in dict[continents])
                {
                    string country = kvp.Key;
                    List<string> city = kvp.Value;
                    
                    Console.WriteLine($"{country} -> {string.Join(", ", city)}");
                }
            }

        }
    }
}
