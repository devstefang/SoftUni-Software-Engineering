using System;
using System.Linq;

namespace _5._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string numberChars = string.Empty;
            string letterChars = string.Empty;
            string Chars = string.Empty;
            foreach (char ch in word)
            {
                if (char.IsDigit(ch))
                {
                    numberChars += ch;
                }
               else if (char.IsLetter(ch))
                {
                    letterChars += ch;
                }
                else
                {
                    Chars += ch;
                }
            }
            Console.WriteLine(numberChars);
            Console.WriteLine(letterChars);
            Console.WriteLine(Chars);


        }
    }
}
