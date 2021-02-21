using System;
using System.Linq;
namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintAscii(firstChar, secondChar);
        }

       

        private static void PrintAscii(char firstChar, char secondChar)
        {
            bool isCorrect = false;
           
            for (int i = firstChar + 1; i < secondChar; i++)
            {
                Console.Write((char)i);
                isCorrect = true;
                 
            }
            if (isCorrect == false)
            {
                for (int i = secondChar + 1; i < firstChar; i++)
                {
                    Console.Write(" "+(char)i);
                    

                }
            }
            

        }
    }
}

