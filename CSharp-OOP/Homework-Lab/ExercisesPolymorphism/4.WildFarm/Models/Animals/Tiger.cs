using _4.WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm.Models.Animals
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight,string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
            Console.WriteLine("ROAR!!!");
        }

        protected override double WeightPerFood => 1.00;

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
