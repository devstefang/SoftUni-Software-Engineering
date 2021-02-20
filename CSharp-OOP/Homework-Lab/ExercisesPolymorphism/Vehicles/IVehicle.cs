﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
   public interface IVehicle
    {
        public double TankCapacity { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumptionPerKm { get; set; }
        void Drive(double distance);
        void Refuel(double liters);
    }
}
