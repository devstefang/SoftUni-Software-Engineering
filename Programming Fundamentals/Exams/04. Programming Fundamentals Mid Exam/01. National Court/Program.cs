using System;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int peopleToAnswer = int.Parse(Console.ReadLine());

            int sum = employee1 + employee2 + employee3;
            int time = 0;
            while (peopleToAnswer > 0)
            {
                  time++;
                if (time % 4 == 0)
                {
                    continue;
                }
                peopleToAnswer -= sum;
            }
            Console.WriteLine($"Time needed: {time}h.");



        }
    }
}
