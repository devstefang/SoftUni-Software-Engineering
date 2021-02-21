﻿using System;
using System.Linq;

namespace _4.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            

            foreach (var item in bannedWords)
            {
               text = text.Replace(item, new string('*',item.Length));
            }

            
            Console.WriteLine(text);

           
        }
    }
}
