using System;

namespace _01.CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int wonBattles = 0;
            string command = Console.ReadLine();
            while (command!= "End of battle")
            {
                int distance = int.Parse(command);
                
                
                energy -= distance;
                if (energy >= distance)
                {
                    wonBattles++;
                }
                if (wonBattles % 3 == 0 && energy > distance)
                {
                    energy += wonBattles;
                }
                if (energy < distance)
                {
                    if (energy > int.MinValue )
                    {
                        energy = 0;
                    }
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
                    break;
                }
                



                command = Console.ReadLine();



            }
            if (command == "End of battle")
            {
                Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
            }
          

        }
    }
}
