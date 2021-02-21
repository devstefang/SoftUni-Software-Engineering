﻿//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace _05._Bomb_Numbers
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<int> numbers = Console.ReadLine()
//                                          .Split()
//                                      .Select(int.Parse)
//                                      .ToList();
//            int[] bombNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//            for (int i = 0; i < numbers.Count; i++)
//            {
//                if (bombNumbers[0] == numbers[i])
//                {

//                    int indexRatio = i;
//                    for (int k = 0;  k < bombNumbers[1]; k++)
//                    {

//                        numbers.RemoveAt(indexRatio + 1);
//                        indexRatio++;
//                    }
//                    for (int j = 0; j < bombNumbers[1]; j++)
//                    {
//                        int indexRemover = 0;
//                        numbers.RemoveAt(bombNumbers[0] + indexRemover );
//                        indexRemover--;
//                    }
//                    numbers.Remove(bombNumbers[0]);
//                }

//            }
//            Console.WriteLine(string.Join("",numbers.Sum()));
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bomb = bombAndPower[0];
            int power = bombAndPower[1];

            for (int i = 0; i < numbers.Count; i++)
            {

                int indexNum = numbers.IndexOf(bomb);
                if (indexNum < 0)
                {
                    break;
                }
                int startIndex = GetStartIndex(indexNum, power, numbers);
                int countLeftElements = CalculateLeftElements(startIndex, indexNum);
                int count = GetCount(power, numbers, indexNum, countLeftElements);
                numbers.RemoveRange(startIndex, count);
            }
            Console.WriteLine(numbers.Sum());
        }

        private static int CalculateLeftElements(int startIndex, int indexNum)
        {
            int count = 0;
            for (int i = startIndex; i < indexNum; i++)
            {
                count++;
            }
            return count;
        }

        private static int GetCount(int power, List<int> numbers, int index, int leftCount)
        {
            int count = 0;
            if ((numbers.Count - 1 - index) < power)
            {
                for (int i = index; i < numbers.Count; i++)
                {
                    count++;
                }
            }
            else
            {
                for (int i = 0; i <= power; i++)
                {
                    count++;
                }
            }
            return count + leftCount;
        }

        private static int GetStartIndex(int index, int power, List<int> numbers)
        {
            if (index < power)
            {
                index = 0;
            }
            else
            {
                index = index - power;
            }
            return index;
        }


    }
}
