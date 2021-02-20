using System;

namespace _03.FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            // пол gym boxing yoga zumba dances pilates
            // мъж $42 $41     $45 $34     $51   $39
            //жена $35 $37    $42   $31    $53    $37

            double budget = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double moneyNeeded = 0;
            double sum = 0;
            if (gender == 'm')
            {
                if (sport == "Gym")
                {
                    sum = 42;
                }
                else if (sport == "Boxing")
                {
                    sum = 41;
                }
                else if (sport == "Yoga")
                {
                    sum = 45;
                }
                else if (sport == "Zumba")
                {
                    sum = 34;
                }
                else if (sport == "Dances")
                {
                    sum = 51;
                }
                else if (sport == "Pilates")
                {
                    sum = 39;
                }
                if (age <= 19)
                {
                    sum *= 0.8;
                }
                moneyNeeded = sum - budget;
                if (budget > sum)
                {
                    Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                }
                else
                {
                    Console.WriteLine($"You don't have enough money! You need ${moneyNeeded:f2} more.");
                }
            }
           else if (gender == 'f')
            {
                if (sport == "Gym")
                {
                    sum = 35;
                }
                else if (sport == "Boxing")
                {
                    sum = 37;
                }
                else if (sport == "Yoga")
                {
                    sum = 42;
                }
                else if (sport == "Zumba")
                {
                    sum = 31;
                }
                else if (sport == "Dances")
                {
                    sum = 53;
                }
                else if (sport == "Pilates")
                {
                    sum = 37;
                }
                if (age <= 19)
                {
                    sum *= 0.8;
                }
                moneyNeeded = sum - budget;
                if (budget > sum)
                {
                    Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                }
                else
                {
                    Console.WriteLine($"You don't have enough money! You need ${moneyNeeded:f2} more.");
                }
            }



        }
    }
}
