using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : IVehicle
    {
        private double tankCapacity;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity > tankCapacity ? 0 : fuelQuantity;
            FuelConsumptionPerKm = fuelConsumption;
            TankCapacity = tankCapacity;
        }
        public double TankCapacity { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumptionPerKm { get; set; }

        public void Drive(double distance)
        {
            double perKm = FuelConsumptionPerKm + 1.4;
            double consumption = perKm * distance;
            if (FuelQuantity >= consumption)
            {
                FuelQuantity -= consumption;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }

        public void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");

            }
            else
            {
                double totalFuel = FuelQuantity + liters;

                if (totalFuel > TankCapacity)
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
                else
                {
                    FuelQuantity += liters;
                }
            }
        }
        public void DriveEmpty(double distance)
        {
            double consumption = FuelConsumptionPerKm * distance;
            if (FuelQuantity >= consumption)
            {
                FuelQuantity -= consumption;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }
        public override string ToString()
        {
            return $"Bus: {FuelQuantity:f2}";
        }
    }
}
