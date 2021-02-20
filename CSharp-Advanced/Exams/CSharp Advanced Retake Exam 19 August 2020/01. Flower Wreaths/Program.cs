using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _01._Flower_Wreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lillies = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] roses = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(lillies);
            Queue<int> queue = new Queue<int>(roses);
            int wreathCount = 0;
            double wreathUnitsNeeded = 15;
            double sumFinalWreath = 0;
            while (true)
            {
                ToContinue:
                if (queue.Count <= 0 || stack.Count <= 0)
                {
                    break;
                }
                int neededSum = 0;
                int currLillie = stack.Peek();
                int currRose = queue.Peek();
                 neededSum = currLillie + currRose;
                if (neededSum == wreathUnitsNeeded)
                {
                    stack.Pop();
                    queue.Dequeue();
                    wreathCount++;
                }
                else if (neededSum > wreathUnitsNeeded)
                {
                    while (neededSum >= wreathUnitsNeeded)
                    {
                        currLillie -= 2;
                        if (currLillie + currRose == wreathUnitsNeeded)
                        {
                            stack.Pop();
                            queue.Dequeue();
                            wreathCount++;
                            goto ToContinue;
                        }
                        else if (currLillie + currRose < wreathUnitsNeeded)
                        {
                            sumFinalWreath += currLillie + currRose;
                            stack.Pop();
                            queue.Dequeue();
                            goto ToContinue;
                        }
                    }
                }
                else if (neededSum < wreathUnitsNeeded)
                {
                    sumFinalWreath += currLillie + currRose;
                    stack.Pop();
                    queue.Dequeue();
                    continue;

                }
               
            }
            int bonusWreath = 0;
            if (sumFinalWreath >= wreathUnitsNeeded)
            {
               double sum = Math.Floor(sumFinalWreath / wreathUnitsNeeded);
                bonusWreath = (int)sum;
            }
            wreathCount += bonusWreath;
            if (wreathCount < 5)
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreathCount} wreaths more!");
            }
            else
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathCount} wreaths!");
            }

        }
    }
}
