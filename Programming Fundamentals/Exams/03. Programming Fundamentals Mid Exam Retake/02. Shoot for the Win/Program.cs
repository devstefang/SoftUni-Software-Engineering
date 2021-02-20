using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string imput = Console.ReadLine();
            int count = 0;
            while (imput != "End")
            {
                int index = int.Parse(imput);

                if (index >= 0 && index < numbers.Count)
                {


                    int currentNumber = numbers[index];
                    count++;
                    if (numbers.Contains(currentNumber))
                    {
                        numbers.RemoveAt(index);
                        numbers.Insert(index, -1);
                    }
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == -1)
                        {
                            continue;
                        }
                        if (numbers[i] > currentNumber)
                        {
                            numbers[i] -= currentNumber;
                        }
                        else
                        {
                            numbers[i] += currentNumber;
                        }

                    }
                }
                imput = Console.ReadLine();

            }
            Console.WriteLine($"Shot targets: {count} -> {string.Join(" ",numbers)}");


        }
    }
}
