using System;
using System.IO;

namespace Vehicles
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = null;
            Truck truck = null;
            Bus bus = null;
            for (int i = 0; i < 3; i++)
            {
                string[] vehicleInfo = Console.ReadLine().Split();
                if (vehicleInfo[0] == "Car")
                {
                    double vehicleFuelQuantity = double.Parse(vehicleInfo[1]);
                    double vehicleFuelConsumption = double.Parse(vehicleInfo[2]);
                    double tankCapacity = double.Parse(vehicleInfo[3]);
                    car = new Car(vehicleFuelQuantity, vehicleFuelConsumption, tankCapacity);
                }
                else if (vehicleInfo[0] == "Bus")
                {
                    double vehicleFuelQuantity = double.Parse(vehicleInfo[1]);
                    double vehicleFuelConsumption = double.Parse(vehicleInfo[2]);
                    double tankCapacity = double.Parse(vehicleInfo[3]);
                    bus = new Bus(vehicleFuelQuantity, vehicleFuelConsumption, tankCapacity);
                }
                else
                {
                    double vehicleFuelQuantity = double.Parse(vehicleInfo[1]);
                    double vehicleFuelConsumption = double.Parse(vehicleInfo[2]);
                    double tankCapacity = double.Parse(vehicleInfo[3]);
                    truck = new Truck(vehicleFuelQuantity, vehicleFuelConsumption,tankCapacity);
                }
                
            }
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                string action = cmdArgs[0];
                string vehicle = cmdArgs[1];
                if (action == "Drive" && vehicle == "Car")
                {
                    double distance = double.Parse(cmdArgs[2]);
                    car.Drive(distance);
                }
                else if (action == "Drive" && vehicle == "Truck")
                {
                    double distance = double.Parse(cmdArgs[2]);
                    truck.Drive(distance);
                }
                else if (action == "Refuel" && vehicle == "Car")
                {
                    double liters = double.Parse(cmdArgs[2]);
                    car.Refuel(liters);
                }
                else if (action == "Refuel" && vehicle == "Truck")
                {
                    double liters = double.Parse(cmdArgs[2]);
                    truck.Refuel(liters);
                }
               else if (action == "Drive" && vehicle == "Bus")
                {
                    double distance = double.Parse(cmdArgs[2]);
                    bus.Drive(distance);
                } 
               else if (action == "DriveEmpty" && vehicle == "Bus")
                {
                    double distance = double.Parse(cmdArgs[2]);
                    bus.DriveEmpty(distance);
                }
                else if (action == "Refuel" && vehicle == "Bus")
                {
                    double liters = double.Parse(cmdArgs[2]);
                    bus.Refuel(liters);
                }

            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
