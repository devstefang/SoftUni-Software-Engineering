using System;

namespace _05._Division_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            double dayCount = int.Parse(Console.ReadLine());
            double hourCount = int.Parse(Console.ReadLine());
            double totalSum1 = 0;
            double totalSum2 = 0;
            double finalSum = 0;

            for (int i = 1; i <= dayCount; i++)
            {
                
                for (int j = 1; j <= hourCount; j++)
                {
                    
                    if (i % 2 == 1 && j % 2 == 0)
                    {
                        totalSum1 += 1.25;
                    }
                    else if (i % 2 == 0 && j % 2 == 1)
                    {
                        totalSum2 += 2.5;
                    }
                    else if (i % 2 == 1 && j % 2 == 1)
                    {
                        totalSum1 += 1;
                    }
                    else if (i % 2 == 0 && j % 2 == 0)
                    {
                        totalSum2 += 1;
                    }
                    
                }
                finalSum += totalSum1 + totalSum2;
                if (i % 2 == 1)
                {
                    Console.WriteLine($"Day: {i} - {totalSum1:f2} leva");
                    
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine($"Day: {i} - {totalSum2:f2} leva");
                    
                }
                totalSum1 = 0;
                totalSum2 = 0;
            }
            Console.WriteLine($"Total: {finalSum:f2} leva");
        }
    }
}
