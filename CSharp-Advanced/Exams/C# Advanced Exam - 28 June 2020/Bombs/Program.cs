using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bombeffect = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] bombcasing = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(bombeffect);
            Stack<int> stack = new Stack<int>(bombcasing);
           const int daturaBomb = 40;
            int daturaBombCount = 0;
            const int CherryBomb = 60;
            int CherryBombCount = 0;
            int smokeDecoy = 120;
            int smokeDecoyCount = 0;
            int sum = 0;
            int repeatCount = 0;
            bool isEnough = false;
            while (stack.Count > 0 && queue.Count > 0)
            {

                int currBombEffect = queue.Peek();
                repeatCount = 0;
                if (isEnough == true)
                {
                    break;
                }
                for (int j = 0; j < bombcasing.Length; j++)
                {
                    if (daturaBombCount >= 3 && CherryBombCount >= 3 && smokeDecoyCount >= 3)
                    {
                        isEnough = true;
                        break; 
                    }
                    if (repeatCount == 0)
                    {
                        int currBombCasing = stack.Peek();
                        sum = currBombCasing + currBombEffect;

                    }
                    else
                    {
                        int currBombCasing = stack.Peek();
                        sum = currBombCasing - 5*repeatCount + currBombEffect;


                    }
                    if (sum < daturaBomb )
                    {

                    }
                    if (sum == daturaBomb )
                    {
                        daturaBombCount++;
                        queue.Dequeue();
                        stack.Pop();
                        break;
                    }
                    else if (sum == CherryBomb)
                    {
                        CherryBombCount++;
                        stack.Pop();
                        queue.Dequeue();

                        break;
                    }
                    else if (sum == smokeDecoy)
                    {
                        smokeDecoyCount++;
                        stack.Pop();
                      queue.Dequeue();
                        break;
                    }
                    else
                    {
                        repeatCount++;
                    }
                }
            }
            if (daturaBombCount >= 3 && CherryBombCount >=3 && smokeDecoyCount >=3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ",queue)}");
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ",stack)}");
            }
           

            Console.WriteLine($"Cherry Bombs: {CherryBombCount}");
            Console.WriteLine($"Datura Bombs: {daturaBombCount}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyCount}");
        }
    }
}
