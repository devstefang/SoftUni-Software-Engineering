using System;

namespace _01._Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double dailyPlunder = double.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double totalPlunder = 0;
            for (int i = 1; i <= days; i++)
            {
                totalPlunder += dailyPlunder;
                if (i % 3 == 0)
                {
                    totalPlunder += dailyPlunder * 0.5 ;
                }
                if (i % 5 == 0)
                {
                    totalPlunder *= 0.7;
                }

                


            }
            double percentage = (totalPlunder / expectedPlunder) * 100;
            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }



        }
    }
}
