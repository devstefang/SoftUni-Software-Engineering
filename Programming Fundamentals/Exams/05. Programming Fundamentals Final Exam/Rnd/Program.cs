using System;
using System.Collections.Generic;

namespace Rnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] ancug = Console.ReadLine()
                .Split(' ');
            int index = rnd.Next(ancug.Length);
            int noCounter = 0;
            int yesCounter = 0;

            for (int i = 0; i < 5; i++)
            {
                string skinOrNot = string.Empty;

                index = rnd.Next(ancug.Length);
                 skinOrNot = ancug[index];
                if (skinOrNot.Contains("no"))
                {
                    noCounter++;
                }
                else
                {
                    yesCounter++;
                }
                
            }
            if (noCounter > yesCounter)
            {
                Console.WriteLine("Nqma da imash skin :P");
            }
            else
            {
                Console.WriteLine("shte imash skin <3");
            }
   
        }
    }
}
