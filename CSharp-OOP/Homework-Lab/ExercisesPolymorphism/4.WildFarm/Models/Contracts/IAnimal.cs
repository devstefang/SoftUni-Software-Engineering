using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm.Models.Contracts
{
   public interface IAnimal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

    }
}
