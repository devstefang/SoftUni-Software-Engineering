using System;

namespace TestExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int time = 1;
            bool isAnswered = false;
            while (!isAnswered)
            {
                int studentsAnsweredPerHour = employee1 + employee2 + employee3;
                for (int i = 0; i < int.MaxValue; i++)
                {

                    studentsAnsweredPerHour += studentsAnsweredPerHour;
                    students -= studentsAnsweredPerHour;
                    time++;
                    if (i % 4 == 0)
                    {
                        time += 1;
                    }
                    if (students <= 0)
                    {
                        Console.WriteLine($"Time needed: {time}h.");
                        isAnswered = true;
                    }
                    if (isAnswered)
                    {
                        break;
                    }
                }



            }
        }
    }
}
