using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleInGroup = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayInWeek = Console.ReadLine();
            double  pricePerDay = 0;
            double totalPrice = 0;

            switch (dayInWeek)
            { 
                   
                case "Friday":
                    if (groupType == "Students")
                    {
                        pricePerDay = 8.45;
                    }
                    if (groupType == "Business")
                    {
                        pricePerDay = 10.9;
                    }
                    if (groupType == "Regular")
                    {
                        pricePerDay = 15;
                    }
                    break;
                case "Saturday":
                    if(groupType == "Students")
                    {
                        pricePerDay = 9.8;
                    }
                    if (groupType == "Business")
                    {
                        pricePerDay = 15.60;
                    }
                    if (groupType == "Regular")
                    {
                        pricePerDay = 20;
                    }
                    break;
                case "Sunday":
                    if(groupType == "Students")
                    {
                        pricePerDay = 10.46;
                    }
                    if (groupType == "Business")
                    {
                        pricePerDay = 16;
                    }
                    if (groupType == "Regular")
                    {
                        pricePerDay = 22.5;
                    }
                    break;
            }
            totalPrice = pricePerDay * peopleInGroup;
            if (groupType == "Students" && peopleInGroup >= 30)
            {
                totalPrice *= 0.85;
            }
            if (groupType == "Business" && peopleInGroup >= 100)
            {
                totalPrice = totalPrice - (pricePerDay * 10);
            }
            if (groupType == "Regular" && peopleInGroup >= 10 && peopleInGroup <= 20)
            {
                totalPrice *= 0.95;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
