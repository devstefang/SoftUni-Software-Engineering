using System;

namespace _04._Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double budget = double.Parse(Console.ReadLine());
            string product = "";
            double productPrice = 0;
            double moneyNeeded = 0;
            int countOfItems = 0;
            double totalSum = 0;
            while (product != "Stop" || budget > productPrice)
            {
                
                product = Console.ReadLine();
                
                if (product == "Stop")
                {
                    break;
                }
                countOfItems++;
                productPrice = double.Parse(Console.ReadLine());
                if (countOfItems % 3 == 0)
                {
                    productPrice *= 0.5;
                }
                totalSum += productPrice;
                
                if (budget < productPrice || totalSum > budget)
                {
                    break;
                }
                
            }
            moneyNeeded = totalSum - budget;
            if (budget > totalSum)
            {
                Console.WriteLine($"You bought {countOfItems} products for {totalSum:f2} leva.");
            }
            else
            {
                Console.WriteLine("You don't have enough money!");
                Console.WriteLine($"You need {moneyNeeded:f2} leva!");
            }
        }
    }
}
