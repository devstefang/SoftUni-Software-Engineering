using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _1.Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tasksValue = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] threadValue = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> tasks = new Stack<int>(tasksValue);
            Queue<int> threads = new Queue<int>(threadValue);
            bool isValidTask = false;
            int valueOfTask = int.Parse(Console.ReadLine());
            int finalThreadValue = 0;
            while (true)
            {
                if (tasks.Count == 0 || threads.Count == 0 || isValidTask == true)
                {
                    break;
                }
                int currentTask = tasks.Peek();
                int currentThread = threads.Peek();
                isValidTask = currentTask == valueOfTask;
                int sumTask = currentThread + currentTask;
                if (currentThread >= currentTask && isValidTask == false)
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else if (isValidTask )
                {
                    finalThreadValue = currentThread;
                }
                else if (currentTask > currentThread)
                {
                    threads.Dequeue();
                }

            }
            Console.WriteLine($"Thread with value {finalThreadValue} killed task {valueOfTask}");
            Console.WriteLine($"{string.Join(" ",threads)}");

        }
    }
}
