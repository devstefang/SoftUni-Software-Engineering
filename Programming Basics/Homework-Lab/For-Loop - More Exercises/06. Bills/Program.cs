using System;
using System.Xml.Schema;

namespace _06._Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int monthsForBills = int.Parse(Console.ReadLine());
            
            double water = 20;
            double  internet = 15;
            double electricity = 0;


            for (int i = 1; i <= monthsForBills; i++)
            {
                double priceOfMonthlyBill = double.Parse(Console.ReadLine());

                double totalElectricity = electricity * priceOfMonthlyBill;
                double totalWater = water * monthsForBills;
                double totalInternet = internet * monthsForBills;

                double otherBills = (priceOfMonthlyBill + water + internet) + 20 / 100;
                double averageBills = (electricity + totalInternet + totalWater + otherBills) / 5;

            }
            
            Console.WriteLine(water);
        }
    }
}
