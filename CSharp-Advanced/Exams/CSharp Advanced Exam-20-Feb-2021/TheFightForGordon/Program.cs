using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFightForGordon
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWaves = int.Parse(Console.ReadLine());

 
            List<int> platesList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            Stack<int> orcsStack = new Stack<int>();

            for (int i = 1; i <= numberOfWaves; i++)
            {
                if (platesList.Count == 0)
                {
                    break;
                }
                int[] orcs = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();


                if (i % 3 == 0)
                {
                    int additionalPlates = int.Parse(Console.ReadLine());
                    platesList.Add(additionalPlates);
                }

                foreach (var orc in orcs)
                {
                    orcsStack.Push(orc);
                }
                while (platesList.Count > 0 && orcsStack.Count > 0)
                {
                    int currentWarrior = orcsStack.Pop();
                    int currentPlates = platesList[0];

                    if (currentPlates > currentWarrior)
                    {
                        currentPlates -= currentWarrior;
                        platesList[0] = currentPlates;
                    }
                    else if (currentPlates < currentWarrior)
                    {
                        currentWarrior -= currentPlates;
                        orcsStack.Push(currentWarrior);
                        platesList.RemoveAt(0);
                    }
                    else
                    {
                        platesList.RemoveAt(0);
                    }

                }
            }
            if (orcsStack.Count > 0)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", orcsStack)}");
            }
            else
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: { string.Join(", ", platesList)}");
            }
        }
    }
}
