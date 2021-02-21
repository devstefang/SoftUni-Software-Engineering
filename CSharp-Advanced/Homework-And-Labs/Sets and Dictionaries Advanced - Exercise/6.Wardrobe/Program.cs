using System;
using System.Collections.Generic;
using System.IO;

namespace _6.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string info = Console.ReadLine();
                string[] information = info.Split(" -> ");
                string color = information[0];
                var dressSplit = information[1].Split(",");
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                for (int j = 0; j < dressSplit.Length; j++)
                {
                   
                    if (!wardrobe[color].ContainsKey(dressSplit[j]))
                    {
                        wardrobe[color].Add(dressSplit[j], new int());
                    }
                    wardrobe[color][dressSplit[j]]++;
                }
            }
            string[] findClothing = Console.ReadLine().Split();
            foreach (var kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                foreach (var clothing in kvp.Value)
                {
                    if (clothing.Key == findClothing[1] && findClothing[0] == kvp.Key)
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
                        continue; 
                    }
                    Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                }
            }

        }
    }
}
