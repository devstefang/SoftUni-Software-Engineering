using System;

namespace _02.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberForDivision = int.Parse(Console.ReadLine());
            if (numberForDivision % 2 == 0)
            {
                if (numberForDivision % 10 == 0)
                {
                    Console.WriteLine("The number is divisible by 10");
                    Environment.Exit(0);
                }
                if (numberForDivision % 7 == 0)
                {
                    Console.WriteLine("The number is divisible by 7");
                    Environment.Exit(0);
                }
                if (numberForDivision % 6 == 0)
                {
                    Console.WriteLine("The number is divisible by 6");
                    Environment.Exit(0);
                }
                if (numberForDivision % 3 == 0)
                {
                    Console.WriteLine("The number is divisible by 3");
                    Environment.Exit(0);
                }
                Console.WriteLine("The number is divisible by 2");
            }
            else if (numberForDivision % 3 == 0)
            {
                if (numberForDivision % 10 == 0)
                {
                    Console.WriteLine("The number is divisible by 10");
                    Environment.Exit(0);
                }
                if (numberForDivision % 7 == 0)
                {
                    Console.WriteLine("The number is divisible by 7");
                    Environment.Exit(0);
                }
                if (numberForDivision % 6 == 0)
                {
                    Console.WriteLine("The number is divisible by 6");
                    Environment.Exit(0);
                }
                Console.WriteLine("The number is divisible by 3");
            }
          else if (numberForDivision % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
                if (numberForDivision % 10 == 0)
                {
                    Console.WriteLine("The number is divisible by 10");
                    Environment.Exit(0);
                }
                    if (numberForDivision % 7 == 0)
                    {
                        Console.WriteLine("The number is divisible by 7");
                        Environment.Exit(0);
                    }
                
            }
            else if (numberForDivision % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
                if (numberForDivision % 10 == 0)
                {
                    Console.WriteLine("The number is divisible by 10");
                    Environment.Exit(0);
                }

            }
           else  if (numberForDivision % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }


        }
    }
}
