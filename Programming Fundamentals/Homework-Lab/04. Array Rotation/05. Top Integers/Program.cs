using System;
using System.Linq;
namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sum = Console.ReadLine() .Split(" ").
                                            Select(int.Parse).
                                            ToArray();
            bool isEqual = false;
            for (int curr= 0; curr < sum.Length; curr++)
            {
                int sumRight = 0;
                for (int i = curr + 1; i < sum.Length; i++)
                {
                    sumRight += sum[i];
                }
                int sumLeft = 0;
                for (int i = curr - 1; i >= 0; i--)
                {
                    sumLeft += sum[i];
                }
                if (sumLeft == sumRight)
                {
                    Console.WriteLine(curr);
                    isEqual = true;
                }
                else
                {
                    Console.WriteLine("no");
                }
                if (!isEqual)
                {
                    break;
                }
            }



            


        }
    }
}
