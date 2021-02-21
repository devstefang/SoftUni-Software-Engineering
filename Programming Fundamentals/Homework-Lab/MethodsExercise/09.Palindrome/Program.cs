using System;

namespace _09.Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            int number = 0;
            bool isPalindrome = false;
            int sum = 0;
            int secondSum = 0;
            while (input != "END")
            {
                 input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                int.Parse(input);
                for (int i = 0;  i < input.Length; i++)
                {
                     sum += input[i];
                }
                for (int j = input.Length - 1; j >= 0; j--)
                {
                    secondSum += input[j];
                }
                if (sum == secondSum)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
       
    }
}
