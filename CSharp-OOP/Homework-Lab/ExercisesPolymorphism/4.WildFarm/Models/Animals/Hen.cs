using _4.WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm.Models.Animals
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
            Console.WriteLine("Cluck");
        }

        protected override double WeightPerFood => 0.35;

        protected override void Validate(Food food)
        {
           
        }
    }
}
