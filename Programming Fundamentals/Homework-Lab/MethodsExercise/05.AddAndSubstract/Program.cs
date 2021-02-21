using System;

namespace _05.AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            AddMethod( num1,  num2,  num3);
            SubtractMethod(num1, num2, num3);
        }
        private static int AddMethod(int num1,int num2, int num3)
        {
            int addedSum = num1 + num2;

            return addedSum;
           
        }
        private static int SubtractMethod(int num1, int num2, int num3)
        {
            int result = AddMethod(num1, num2, num3) - num3;
            Console.WriteLine(result);
            return result;
        }
    }
}
