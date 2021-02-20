using System;

namespace _01._Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            const double bitcoinRate = 1168;
            const double uanRate = 0.15;
            const double dollarRate = 1.76;
            const double euroRate = 1.95;

            double bitcoins = double.Parse(Console.ReadLine());
            double uans = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());
            //Calculations
            double totalSum = bitcoins * bitcoinRate + (uanRate * uans) * 1.76;
            double totalEuro = totalSum / 1.95;
            double commisionTax = totalEuro * commision / 100;
            double finalSum = totalEuro - commisionTax;
            Console.WriteLine($"{finalSum:f2}");

        }
    }
}
