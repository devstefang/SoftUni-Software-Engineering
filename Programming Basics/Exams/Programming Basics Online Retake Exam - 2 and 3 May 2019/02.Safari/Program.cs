using System;

namespace _02.Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Цената на един литър гориво е 2.10 лв.
            //• Цената за екскурзовод е 100лв.
            //• В зависимост от деня има отстъпки от общата цена - за събота 10 %, а за неделя 20 %

            const double litreGas = 2.1;
            const double travelGuide = 100;

            double budget = double.Parse(Console.ReadLine());
            double gasNeeded = double.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();
            double moneyLeft = 0;
            double moneyNeeded = 0;

            while (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                double totalExpenses = (litreGas * gasNeeded) + travelGuide ;
                if (dayOfWeek == "Saturday")
                {
                    totalExpenses *= 0.9;
                }
                else
                {
                    totalExpenses *= 0.8;
                }
                moneyLeft = budget - totalExpenses;
                moneyNeeded = totalExpenses - budget;
                if (budget >= totalExpenses)
                {
                    Console.WriteLine($"Safari time! Money left: {moneyLeft:f2} lv. ");
                }
                else
                {
                    Console.WriteLine($"Not enough money! Money needed: {moneyNeeded:f2} lv.");
                }
                break;
            }
            
        }
    }
}
