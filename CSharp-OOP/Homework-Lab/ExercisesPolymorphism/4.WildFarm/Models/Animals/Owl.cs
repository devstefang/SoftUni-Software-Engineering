using _4.WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm.Models.Animals
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
            Console.WriteLine("Hoot Hoot");
        }

        protected override double WeightPerFood => 0.25;

        protected override void Validate(Food food)
        {
            string type = food.GetType().Name;
            if (type != nameof(Meat))
            {
                Throw(food);
            }
        }
    }
}
