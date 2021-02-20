using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : IVehicle
    {
          private double fuelConsumption;
        private double tankCapacity;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
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
                this.fuelConsumption = value + 1.6;
            }
        }
        public double TankCapacity { get; set; }
        public void Drive(double distance)
        {
            double consumption = distance * FuelConsumptionPerKm;
            if (FuelQuantity >= consumption)
            {
                FuelQuantity -= consumption;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Truck needs refueling");
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
                double totalFuel = FuelQuantity + (liters * 0.95);

                if (totalFuel > TankCapacity)
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
                else
                {
                    liters = liters * 0.95;
                    FuelQuantity += liters;
                }
            }
            
        }
        public override string ToString()
        {
            return $"Truck: {FuelQuantity:f2}";
        }
    }
}
