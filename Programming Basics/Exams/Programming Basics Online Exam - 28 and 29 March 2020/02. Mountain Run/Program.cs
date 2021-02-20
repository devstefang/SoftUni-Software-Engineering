using System;

namespace _02._Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeForMeter = double.Parse(Console.ReadLine());

            //Calculations
            double meterToCover = distanceInMeters * timeForMeter;
            double slowingPerMinute = Math.Floor(distanceInMeters / 50) * 30;
            double totalTime = meterToCover + slowingPerMinute;
            double leftTime = totalTime - recordInSeconds;
            if (totalTime < recordInSeconds)
            {
                Console.WriteLine($" Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {leftTime:f2} seconds slower.");
            }

        }
    }
}
