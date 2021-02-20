using System;

namespace _03.EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string setSize = Console.ReadLine();
            int setsOrdered = int.Parse(Console.ReadLine());
            double watermelonPrice = 0;
            double mangoPrice = 0;
            double pineapplePrice = 0;
            double raspberryPrice = 0;
            if (setSize == "small")
            {
                switch (fruit)
                {
                    case "Watermelon":
                        watermelonPrice = 2 * 56 * setsOrdered;
                        break;
                    case "Mango":
                        mangoPrice = 2 * 36.66 * setsOrdered;
                        break;
                    case "Pineapple":
                        pineapplePrice = 2 * 42.10 * setsOrdered;
                        break;
                    case "Raspberry":
                        raspberryPrice = 2 * 20 *setsOrdered;
                        break;
                }
                double totalPrice = watermelonPrice + mangoPrice + pineapplePrice + raspberryPrice;
                if (totalPrice >= 400 && totalPrice <= 1000)
                {
                    totalPrice *= 0.85;
                    Console.WriteLine($"{totalPrice:f2} lv.");
                }
                
                else if (totalPrice > 1000)
                {
                    totalPrice *= 0.5;
                    Console.WriteLine($"{totalPrice:f2} lv.");
                }
                else if( totalPrice < 400)
                {
                    Console.WriteLine($"{totalPrice:f2} lv.");
                }
            }
            else if (setSize == "big")
            {
                switch (fruit)
                {
                    case "Watermelon":
                        watermelonPrice = 5 * 28.70 * setsOrdered;
                        break;
                    case "Mango":
                        mangoPrice = 5 * 19.60 * setsOrdered;
                        break;
                    case "Pineapple":
                        pineapplePrice = 5 * 24.80 * setsOrdered;
                        break;
                    case "Raspberry":
                        raspberryPrice = 5 * 15.20 * setsOrdered;
                        break;
                }
                double totalPrice = watermelonPrice + mangoPrice + pineapplePrice + raspberryPrice;
                if (totalPrice >= 400 && totalPrice <= 1000)
                {
                    totalPrice *= 0.85;
                    Console.WriteLine($"{totalPrice:f2} lv.");
                }
                

                else if (totalPrice > 1000)
                {
                    totalPrice *= 0.5;
                    Console.WriteLine($"{totalPrice:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"{totalPrice:f2} lv.");
                }
            }
        }
    }
}
