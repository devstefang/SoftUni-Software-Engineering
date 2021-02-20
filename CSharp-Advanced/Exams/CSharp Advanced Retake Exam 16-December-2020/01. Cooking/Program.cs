using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _01._Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            int bread = 25;
            int breadCount = 0;
            int cake = 50;
            int cakeCount = 0;
            int pastry = 75;
            int pastryCount = 0;
            int fruitPie = 100;
            int fruitPieCount = 0;
            int[] liquidInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] ingredientInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> liquids = new Queue<int>(liquidInfo);
            Stack<int> ingredients = new Stack<int>(ingredientInfo);
            while (true)
            {
                if (liquids.Count == 0 || ingredients.Count == 0)
                {
                    break;
                }
                int currIngredient = ingredients.Peek();
                 Continue:
                if (liquids.Count == 0 || ingredients.Count == 0)
                {
                    break;
                }
                int currLiquid = liquids.Peek();
                int sum = currIngredient + currLiquid;
                if (sum == bread)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    breadCount++;
                }
                else if (sum == cake)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    cakeCount++;
                }
                else if (sum == pastry)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    pastryCount++;
                }
                else if (sum == fruitPie)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    fruitPieCount++;
                }
                else 
                {
                    liquids.Dequeue();
                    currIngredient += 3;
                    ingredients.Pop();
                    ingredients.Push(currIngredient);
                    goto Continue;
                    // If it bugs check count!
                }
                
            }
            if (breadCount >= 1 && cakeCount >= 1 && pastryCount >= 1 && fruitPieCount >= 1)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }
            if (liquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else 
            {
                Console.WriteLine($"Liquids left: {string.Join(", ",liquids)}");
            }
            if (ingredients.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ",ingredients)}");
            }
            Console.WriteLine($"Bread: {breadCount}");
            Console.WriteLine($"Cake: {cakeCount}");
            Console.WriteLine($"Fruit Pie: {fruitPieCount}");
            Console.WriteLine($"Pastry: {pastryCount}");
        }
    }
}
