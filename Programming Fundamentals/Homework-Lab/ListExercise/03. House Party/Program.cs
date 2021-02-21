using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int expectedVisitors = int.Parse(Console.ReadLine());
            string[] peopleSplit = { };
            

            List<string> guests = new List<string>();


            for (int i = 0; i < expectedVisitors; i++)
            {
                string peopleForParty = Console.ReadLine();
                peopleSplit = peopleForParty.Split();
                string name = peopleSplit[0];
                if (peopleSplit.Length > 3)
                {


                    if (guests.Contains(name))
                    {
                        guests.Remove(name);

                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                else
                {


                    if (!guests.Contains(name))
                    {
                        guests.Add(name);

                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
            }    

            Console.WriteLine(string.Join(Environment.NewLine,guests));

        }
    }
}
