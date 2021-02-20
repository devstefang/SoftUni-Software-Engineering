using System;
using System.IO;

namespace _1._Generic_Box_of_String
{
   public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
                string input = Console.ReadLine();
                Box<string> box = new Box<string>(input);
                Console.WriteLine(box);
            }
        }
    }
}
