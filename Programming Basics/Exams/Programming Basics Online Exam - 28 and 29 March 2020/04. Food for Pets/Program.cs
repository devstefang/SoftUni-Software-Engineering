using System;

namespace _04._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double foodToEat = double.Parse(Console.ReadLine());
            double dogSum = 0;
            double catSum = 0;
            double biscuits = 0;
            for (int i = 1; i <= days; i++)
            {
                
                double dogsFood = int.Parse(Console.ReadLine());
                double catsFood = int.Parse(Console.ReadLine());
                dogSum += dogsFood;
                catSum += catsFood;
                if (i % 3 == 0)
                {
                    double currentBiscuits = (dogsFood + catsFood) * 10 / 100;
                    biscuits += currentBiscuits;
                }
                

                
            }
            double totalFood = dogSum + catSum;
            double percentageOfTotalFood = totalFood / foodToEat * 100;
            double percentageDogFood = dogSum / totalFood * 100;
            double percentageCatFood = catSum / totalFood * 100;
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{percentageOfTotalFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{percentageDogFood:f2}% eaten from the dog.");
            Console.WriteLine($"{percentageCatFood:f2}% eaten from the cat.");
        }
    }
}
