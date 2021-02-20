using System;

namespace _02.CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int caloriePerMinute = 5;
            int minutesWalking = int.Parse(Console.ReadLine());
            int numberOFWalks = int.Parse(Console.ReadLine());
            int eatenCalories = int.Parse(Console.ReadLine());

            int totalCaloriesBurned = minutesWalking * numberOFWalks * caloriePerMinute;
            if (totalCaloriesBurned >= eatenCalories / 2)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalCaloriesBurned}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalCaloriesBurned}.");
            }






        }
    }
}
