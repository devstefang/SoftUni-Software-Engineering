using System;

namespace _01._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	Пилешко меню –  10.35 лв.
            //•	Меню с риба – 12.40 лв.
            //•	Вегетарианско меню  – 8.15 лв.

            const double chickenMenu = 10.35;
            const double fishMenu = 12.40;
            const double vegetarianMenu = 8.15;

            
            int chickenMenuOrders = int.Parse(Console.ReadLine());
            int fishMenuOrders = int.Parse(Console.ReadLine());
            int vegMenuOrders = int.Parse(Console.ReadLine());

            double chickenTotal = chickenMenuOrders * chickenMenu;
            double fishTotal = fishMenu * fishMenuOrders;
            double vegTotal = vegetarianMenu * vegMenuOrders;

            double totalPrice = chickenTotal + fishTotal + vegTotal;
            double desert = totalPrice * 0.2;
            double finalSum = totalPrice + desert;
            Console.WriteLine($"Total: {finalSum + 2.5:f2}");

        }
    }
}
