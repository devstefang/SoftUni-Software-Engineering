using _4.WildFarm.Models.Animals;
using _4.WildFarm.Models.Contracts;
using _4.WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _4.WildFarm.Engine
{
    public class Engine : IEngine
    {
        public void Run()
        {
            List<Animal> animals = new List<Animal>();
            string command;
            Animal animal = null;
            Food food = null;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] animalInfo = command.Split();
                string type = animalInfo[0];
                if (type == "Hen")
                {
                    double weight = double.Parse(animalInfo[2]);
                    int wingSize = int.Parse(animalInfo[3]);
                    animal = new Hen(animalInfo[1], weight, wingSize);
                }
                else if (type == "Owl")
                {
                    double weight = double.Parse(animalInfo[2]);
                    int wingSize = int.Parse(animalInfo[3]);
                    animal = new Hen(animalInfo[1], weight, wingSize);
                }
                else if (type == "Mouse")
                {
                    string name = animalInfo[1];
                    double weight = double.Parse(animalInfo[2]);
                    string livingRegion = animalInfo[3];
                    animal = new Mouse(name, weight,livingRegion);
                }
                else if (type == "Cat")
                {
                    string name = animalInfo[1];
                    double weight = double.Parse(animalInfo[2]);
                    string livingRegion = animalInfo[3];
                    string breed = animalInfo[4];
                    animal = new Cat(name, weight, livingRegion, breed);
                }
                else if (type == "Tiger")
                {
                    string name = animalInfo[1];
                    double weight = double.Parse(animalInfo[2]);
                    string livingRegion = animalInfo[3];
                    string breed = animalInfo[4];
                    animal = new Tiger(name, weight, livingRegion, breed);
                }
                else if (type == "Dog")
                {
                    string name = animalInfo[1];
                    double weight = double.Parse(animalInfo[2]);
                    string livingRegion = animalInfo[3];
                    animal = new Dog(name,weight,livingRegion);
                }
                string foods = Console.ReadLine();
                string[] foodInfo = foods.Split();
                string foodType = foodInfo[0];
                int quantity = int.Parse(foodInfo[1]);
                if (foodType == "Vegetable")
                {
                    food = new Vegetable(quantity);
                }
                else if (foodType == "Fruit")
                {
                    food = new Fruit(quantity);
                }
                else if (foodType == "Meat")
                {
                    food = new Meat(quantity);
                }
                else if (foodType == "Seeds")
                {
                    food = new Seeds(quantity);
                }
                try
                {
                    animal.Eat(food);
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }

            }
            animals.ForEach(Console.WriteLine);
        }
    }
}
