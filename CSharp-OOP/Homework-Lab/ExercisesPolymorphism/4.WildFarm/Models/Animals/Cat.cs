using _4.WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm.Models.Animals
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
            Console.WriteLine("Meow");
        }

        protected override double WeightPerFood => 0.30;

        protected override void Validate(Food food)
        {
            string type = food.GetType().Name;
            if (type != nameof(Vegetable) && type != nameof(Meat))
            {
                Throw(food);
            }
        }
    }
}
