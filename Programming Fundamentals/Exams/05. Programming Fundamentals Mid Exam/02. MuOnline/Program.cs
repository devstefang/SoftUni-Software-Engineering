using System;
using System.Linq;
namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int btcAmount = 0;
            int currentHealth = 0;
            int room = 0;
            string[] dungeonRooms = Console.ReadLine().Split("|").ToArray();
            bool isNotDead = false;
            for (int i = 0; i < dungeonRooms.Length; i++)
            {
                string command = dungeonRooms[i];
                string[] splittedCommand = command.Split();

                int value = int.Parse(splittedCommand[1]);
                if (splittedCommand[0] == "potion")
                {
                    if (health + value > 100)
                    {
                        currentHealth = health;
                        health = 100;
                        Console.WriteLine($"You healed for {100 - currentHealth} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    else
                    {
                        health += value;
                        Console.WriteLine($"You healed for {value} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                }
                else if (splittedCommand[0] == "chest")
                {
                    btcAmount += value;
                    Console.WriteLine($"You found {value} bitcoins.");
                }
                else
                {
                    health -= value;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {splittedCommand[0]}.");
                    }
                    else
                    {
                        room++;
                        Console.WriteLine($"You died! Killed by {splittedCommand[0]}.");
                        Console.WriteLine($"Best room: {room}");
                        isNotDead = true;
                        
                        break;
                    }
                   
                }
                room++;
            }
            if (isNotDead == false)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {btcAmount}");
                Console.WriteLine($"Health: {health}");
            }



        }
    }
}
