using System;

namespace _07._Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double stadiumCapacity = double.Parse(Console.ReadLine());
            double totalFans = double.Parse(Console.ReadLine());
            double sectorA = 0;
            double sectorB = 0;
            double sectorG = 0;
            double sectorV = 0;
            for (int i = 1; i <= totalFans; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    sectorA += 1;
                }
                else if (sector == "B")
                {
                    sectorB += 1;
                }
                else if (sector == "G")
                {
                    sectorG += 1;
                }
                else if (sector == "V")
                {
                    sectorV += 1;
                }
            }
            
            Console.WriteLine($"{sectorA / totalFans * 100:f2}%");
            Console.WriteLine($"{sectorB / totalFans * 100:f2}%");
            Console.WriteLine($"{sectorV / totalFans * 100:f2}%");
            Console.WriteLine($"{sectorG / totalFans * 100:f2}%");
            Console.WriteLine($"{totalFans / stadiumCapacity * 100:f2}%");

        }
    }
}
