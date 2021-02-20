using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> heroDict = new Dictionary<string, List<int>>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] heroSplitted = input.Split(" ");
                string heroName = heroSplitted[0];
                int hp = int.Parse(heroSplitted[1]);
                int mp = int.Parse(heroSplitted[2]);

                heroDict.Add(heroName, new List<int> { hp, mp });
            }
            string command = Console.ReadLine();
            while (command!= "End")
            {
               string[] cmdArgs = command.Split(" - ");
                string action = cmdArgs[0];
                string heroName = cmdArgs[1];
                if (action == "CastSpell")
                {
                    int manaNeeded = int.Parse(cmdArgs[2]);
                    string spellName = cmdArgs[3];
                    if (heroDict[heroName][1] >= manaNeeded)
                    {
                        heroDict[heroName][1] -= manaNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroDict[heroName][1]} MP!");

                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];
                    if (heroDict[heroName][0] > damage)
                    {
                        heroDict[heroName][0] -= damage;
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroDict[heroName][0]} HP left!");
                    }
                    else
                    {
                        heroDict.Remove(heroName);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                else if (action == "Recharge")
                {
                    int amount = int.Parse(cmdArgs[2]);
                    if (heroDict[heroName][1] + amount > 200)
                    {
                        amount = 200 - heroDict[heroName][1];
                        heroDict[heroName][1] = 200;

                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    }
                    else
                    {
                        heroDict[heroName][1] += amount;
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    }
                }
                else if (action == "Heal")
                {
                    int amount = int.Parse(cmdArgs[2]);
                    if (heroDict[heroName][0] + amount > 100)
                    {
                        amount = 100 - heroDict[heroName][0];
                        heroDict[heroName][0] = 100;

                        Console.WriteLine($"{heroName} healed for {amount} HP!");                    
                    }
                    else
                    {
                        heroDict[heroName][0] += amount;
                        Console.WriteLine($"{heroName} healed for {amount} HP!");              
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var heroStats in heroDict.OrderByDescending(x=>x.Value[0]).ThenBy(x=>x.Key))
            {
                Console.WriteLine(heroStats.Key);
                Console.WriteLine($"HP: {heroStats.Value[0]}");
                Console.WriteLine($"MP: {heroStats.Value[1]}");


            }

        }
    }
}
