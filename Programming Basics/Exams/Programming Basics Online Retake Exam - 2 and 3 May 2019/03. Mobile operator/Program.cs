using System;

namespace _03._Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            //            срок / тип  Small        Middle       Large     ExtraLarge
            //1 година(one)           9.98 лв.    18.99 лв.   25.98 лв.   35.99 лв.
            //2 години(two)            8.58 лв.    17.09 лв.   23.59 лв.   31.79 лв.

            string contractLenght = Console.ReadLine();
            string contractType = Console.ReadLine();
            string internet = Console.ReadLine();
            double monthsToPay = double.Parse(Console.ReadLine());
            double totalSum = 0;
            if (contractLenght == "one")
            {
                switch (contractType)
                {
                    case "Small":
                        totalSum += 9.98;
                        break;
                    case "Middle":
                        totalSum += 18.99;
                        break;
                    case "Large":
                        totalSum += 25.98;
                        break;
                    case "ExtraLarge":
                        totalSum += 35.99;
                        break;
                }

            }
            else
            {
                switch (contractType)
                {


                    case "Small":
                        totalSum += 8.58;
                        break;
                    case "Middle":
                        totalSum += 17.09;
                        break;
                    case "Large":
                        totalSum += 23.59;
                        break;
                    case "ExtraLarge":
                        totalSum += 31.79;
                        break;
                }
            }
                if (internet == "yes")
                {


                    if (totalSum <= 10)
                    {
                        totalSum += 5.5;
                    }
                    else if (totalSum <= 30)
                    {
                        totalSum += 4.35;
                    }
                    else if (totalSum > 30)
                    {
                        totalSum += 3.85;
                    }
                }
                if (contractLenght == "two")
                {
                    totalSum *= 0.9625;
                }
                double finalSum = totalSum * monthsToPay;
                Console.WriteLine($"{finalSum:f2} lv.");


            
        }
    }
}
