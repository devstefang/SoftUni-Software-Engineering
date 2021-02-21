using System;

namespace _03._Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isHappyNum = false;
            while (isHappyNum == false)
            {
                for (int i = 1; i <= 9 ; i++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        for (int k = 1; k <= 9; k++)
                        {
                            for (int l = 1; l <= 9; l++)
                            {
                                if (num % (i + j) == 0 && i +j == k + l)
                                {
                                    Console.Write($"{i}{j}{k}{l} ");
                                    isHappyNum = true;
                                    break;
                                }


                            }
                        }
                    }
                }
            }


        }
    }
}
