using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            
            List<string> usernameList = new List<string>();
            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i].Length >= 3 && usernames[i].Length <=16)
                {
                    if (usernames[i].All(c => char.IsLetterOrDigit(c)) ||usernames[i].Contains("-") || usernames[i].Contains("_") )
                    {
                        usernameList.Add(usernames[i]);
                    }
                }



            }
            Console.WriteLine(string.Join(Environment.NewLine,usernameList));


        }
    }
}
