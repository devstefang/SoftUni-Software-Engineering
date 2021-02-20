using _4.WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm.Models.Animals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight,livingRegion)
        {
            Console.WriteLine("Woof!");
        }

        protected override double WeightPerFood => 0.40;
        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
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
