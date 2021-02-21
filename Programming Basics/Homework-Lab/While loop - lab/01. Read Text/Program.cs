using System;

namespace _01._Read_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = Console.ReadLine();
            string inputPassword = Console.ReadLine();
            while (inputPassword != pass)
            {
                
                
                    inputPassword = Console.ReadLine();
                    
                
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}
