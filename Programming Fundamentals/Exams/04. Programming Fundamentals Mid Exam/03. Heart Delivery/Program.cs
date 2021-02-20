using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighbourhood = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            string[] cmdArgs = command.Split(" ").ToArray();

            int jumpedPosition = 0;
            while (command != "Love!")
            {

                int lenght = int.Parse(cmdArgs[1]);
                jumpedPosition += lenght;
                if (jumpedPosition >= 0 && jumpedPosition < neighbourhood.Length)
                {
                    neighbourhood[jumpedPosition] -= 2;
                }
                else
                {
                    jumpedPosition = 0;
                    neighbourhood[jumpedPosition] -= 2;
                }
                if (neighbourhood[jumpedPosition] == 0)
                {
                    Console.WriteLine($"Place {jumpedPosition} has Valentine's day.");
                }
                else if (neighbourhood[jumpedPosition] < 0)
                {
                    Console.WriteLine($"Place {jumpedPosition} already had Valentine's day.");
                }



                command = Console.ReadLine();
                cmdArgs = command.Split(" ").ToArray();

            }

            Console.WriteLine($"Cupid's last position was {jumpedPosition}.");
            int successfullCount = neighbourhood.Count(x => x == 0);
            int failedCount = neighbourhood.Count(x => x > 0);

            if (failedCount == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failedCount} places.");
            }
        }
    }
}
