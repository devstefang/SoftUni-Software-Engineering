using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
            for (int i = 0; i < n; i++)
            {
                string carInfo = Console.ReadLine();
                string[] splitInfo = carInfo.Split("|");
                string car = splitInfo[0];
                int mileage = int.Parse(splitInfo[1]);
                int fuel = int.Parse(splitInfo[2]);
                dict.Add(car, new List<int> { mileage, fuel });
            }
            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] cmdArgs = command.Split(" : ");
                string action = cmdArgs[0];
                string car = cmdArgs[1];
                if (action == "Drive")
                {
                    int distance = int.Parse(cmdArgs[2]);
                    int fuel = int.Parse(cmdArgs[3]);
                    if (dict[car][1] < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        dict[car][0] += distance;
                        dict[car][1] -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }
                    if (dict[car][0] >= 100000)
                    {
                        dict.Remove(car);
                        Console.WriteLine($"Time to sell the {car}!");
                    }
                }
                else if (action == "Refuel")
                {
                    int fuel = int.Parse(cmdArgs[2]);
                    if (dict[car][1] + fuel > 75)
                    {
                        fuel = 75 - dict[car][1];
                        dict[car][1] = 75;
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                    else
                    {
                        dict[car][1] += fuel;
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                }
                else if (action == "Revert")
                {

                    int kilometers = int.Parse(cmdArgs[2]);
                    dict[car][0] -= kilometers;
                    if (dict[car][0] < 10000)
                    {
                        dict[car][0] = 10000;

                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var car in dict.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }

        }
    }
}
