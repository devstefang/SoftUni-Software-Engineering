using _4.WildFarm.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm.Models.Foods
{
    public abstract class Food : IFood
    {
        public Food(int quantity)
        {
            Quantity = quantity;
        }
        public int Quantity { get; }
    }
}
