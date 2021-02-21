using System;

namespace _01._Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForIvan = double.Parse(Console.ReadLine());
            int yearInPast = int.Parse(Console.ReadLine());
            int ivanYears = 18;
            int lifeCost = 0;
            
            for (int i = 1800; i <= yearInPast; i++)
            {
            
                
                if (i % 2 == 0)
                {
                    lifeCost += 12000;
                }
                
                else if (i % 2 == 1)
                {
                    lifeCost += 12000 + 50 * ivanYears;
                }
                ivanYears++;
                
                
            }
            double leftMoney = moneyForIvan - lifeCost;
            double neededMoney = lifeCost - moneyForIvan;
            if (leftMoney > 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {leftMoney:f2} dollars left.");


            }
            else
            {
                Console.WriteLine($"He will need {neededMoney:f2} dollars to survive.");
            }
        }
    }
}
