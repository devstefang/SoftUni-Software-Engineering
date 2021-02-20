using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] townCharacteristics = Console.ReadLine().Split("||");
            string town = townCharacteristics[0];
            List<int> treasureAndPeople = new List<int>();
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
            while (town != "Sail")
            {
                int population = int.Parse(townCharacteristics[1]);
                int gold = int.Parse(townCharacteristics[2]);
                if (dict.ContainsKey(town))
                {
                    dict[town][0] += population;
                    dict[town][1] += gold;
                    continue;

                }
                dict.Add(town, new List<int> {population,gold });
               


                townCharacteristics = Console.ReadLine().Split("||");
                town = townCharacteristics[0];
            }
            string[] pirateActions = Console.ReadLine().Split("=>");
            string action = pirateActions[0];
            while (action != "End")
            {
                if (action == "Plunder")
                {
                    string city = pirateActions[1];
                    int people = int.Parse(pirateActions[2]);
                    int gold = int.Parse(pirateActions[3]);
                    dict[city][0] -= people;
                    dict[city][1] -= gold;
                    Console.WriteLine($"{city} plundered! {gold} gold stolen, {people} citizens killed.");
                    int peopleCount = dict[city][0];
                    int goldCount = dict[city][1];
                    if (peopleCount <= 0 || goldCount <= 0)
                    {
                        Console.WriteLine($"{city} has been wiped off the map!");
                        dict.Remove(city);
                       
                    }
                }

                if (action == "Prosper")
                {
                    string city = pirateActions[1];
                    int gold = int.Parse(pirateActions[2]);
                    if (gold < 0 )
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        dict[city][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {dict[city][1]} gold.");
                    }

                }



                pirateActions = Console.ReadLine().Split("=>");
                action = pirateActions[0];
            }
            Console.WriteLine($"Ahoy, Captain! There are {dict.Count} wealthy settlements to go to:");
            foreach (var stats in dict.OrderByDescending(t => t.Value[1]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{stats.Key} -> Population: {stats.Value[0]} citizens, Gold: {stats.Value[1]} kg");



            }
        }
    }
}
