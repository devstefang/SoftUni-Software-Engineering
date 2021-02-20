using System;

namespace _04.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            double musala = 0;
            double monblan = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;
            double totalPersons = 0;

            for (int i = 1; i <= groupCount; i++)
            {
                int personsInGroup = int.Parse(Console.ReadLine());
                if (personsInGroup <= 5)
                {
                    musala += personsInGroup;
                }
                else if (personsInGroup >= 6 && personsInGroup <= 12)
                {
                    monblan += personsInGroup;
                }
                else if (personsInGroup >= 13 && personsInGroup <= 25)
                {
                    kilimandjaro += personsInGroup;
                }
                else if (personsInGroup >= 26 && personsInGroup <= 40)
                {
                    k2 += personsInGroup;
                }
                else if (personsInGroup >= 41)
                {
                    everest += personsInGroup;
                }

                totalPersons += personsInGroup;




            }
            double musalaTotal = musala / totalPersons * 100;
            double monblanTotal = monblan / totalPersons * 100;
            double kilimandjaroTotal = kilimandjaro / totalPersons * 100;
            double k2Total = k2 / totalPersons * 100;
            double everestTotal = everest / totalPersons * 100;
            Console.WriteLine($"{musalaTotal:f2}%");
            Console.WriteLine($"{monblanTotal:f2}%");
            Console.WriteLine($"{kilimandjaroTotal:f2}%");
            Console.WriteLine($"{k2Total:f2}%");
            Console.WriteLine($"{everestTotal:f2}%");
            }

        }
    } 
