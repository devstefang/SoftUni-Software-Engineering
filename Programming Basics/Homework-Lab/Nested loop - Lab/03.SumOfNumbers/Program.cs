using System;

namespace _03.SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int steps = 0;
            bool flag = false;
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j < end; j++)
                {
                    steps++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{steps} {i} + {j} = {i + j}");
                        flag = true;
                        break;
                    }
                    
                }
                if (flag)
                {
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine($"{steps} combinations - neither equals {magicNumber}");
            }
            GRESHNO RESHENIE

        }
    }
}
