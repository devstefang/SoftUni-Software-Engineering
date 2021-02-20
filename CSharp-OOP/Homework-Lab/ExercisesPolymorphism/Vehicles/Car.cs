using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : IVehicle
    {
        private double fuelConsumption;
        private double tankCapacity;
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity > tankCapacity ? 0 : fuelQuantity;
            FuelConsumptionPerKm = fuelConsumption;
            TankCapacity = tankCapacity;
        }
        public double FuelQuantity { get; set; }
        public double FuelConsumptionPerKm
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value + 0.9;
            }
        }

        public double TankCapacity{ get; set; }

        public void Drive(double distance)
        {
            double consumption = distance * FuelConsumptionPerKm;
            if (FuelQuantity >= consumption)
            {
                FuelQuantity -= consumption;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Car needs refueling");
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
        public override string ToString()
        {
            return $"Car: {FuelQuantity:f2}";
        }
    }
}
