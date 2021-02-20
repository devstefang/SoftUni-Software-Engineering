using _4.WildFarm.Models.Contracts;
using _4.WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm.Models.Animals
{
    public abstract class Animal : IAnimal
    {
        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        protected abstract double WeightPerFood { get; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }
        public virtual void Eat(Food food)
        {
            Validate(food);
            this.FoodEaten += food.Quantity ;
            Weight += food.Quantity * WeightPerFood;
        }
        protected abstract void Validate(Food food);
        protected void Throw(Food food)
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
    }
}
