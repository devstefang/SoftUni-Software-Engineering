using System;
using System.Collections.Generic;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = double.Parse(Console.ReadLine());
            double lectures = double.Parse(Console.ReadLine());
            double bonus = double.Parse(Console.ReadLine());
            double highestScore = 0;
            double totalBonus = 0;
            double maxValue = int.MinValue;
            double maxAttendances = int.MinValue;
            for (double i = 0; i < students; i++)
            {
                totalBonus = 0;
                double attendance = double.Parse(Console.ReadLine());
                totalBonus = (attendance / lectures) * (5 + bonus);
                if (totalBonus > maxValue )
                {
                    maxValue = totalBonus;
                }
                if (attendance > maxAttendances )
                {
                    maxAttendances = attendance;
                }

            }

            Console.WriteLine($"Max Bonus: {Math.Round(maxValue)}.");

            Console.WriteLine($"The student has attended {maxAttendances} lectures.");
        }
    }
}
