using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            foreach (char ch in input)
            {
                var text = (char)(ch + 3);
                Console.Write(text);
            }


        }
    }
}
