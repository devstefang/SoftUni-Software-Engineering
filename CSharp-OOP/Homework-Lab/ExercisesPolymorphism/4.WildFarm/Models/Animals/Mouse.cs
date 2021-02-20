using _4.WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm.Models.Animals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
            Console.WriteLine("Squeak");
        }

        protected override double WeightPerFood => 0.10;

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }

        protected override void Validate(Food food)
        {
            string type = food.GetType().Name;
            if (type != nameof(Vegetable) && type != nameof(Fruit))
            {
                Throw(food);
            }
        }
    }
}
