using System;

namespace _02._Summer_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            for (int i = 2; i <= firstNum; i+= 2)
            {
                for (int j = 2; j <= secondNum; j++)
                {
                    for (int k = 2; k <= thirdNum; k+=2)
                    {
                        if (j == 2 || j == 3 || j == 5 || j == 7 )
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }



        }
    }
}