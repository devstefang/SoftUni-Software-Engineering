using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.BirthdayCelebrations
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<IBuyer> hashset = new HashSet<IBuyer>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string info = Console.ReadLine();
                string[] cmdArgs = info.Split();
                string name = cmdArgs[0];
                int age = int.Parse(cmdArgs[1]);
                if (cmdArgs.Length == 4)
                {
                    string id = cmdArgs[2];
                    string birthDate = cmdArgs[3];
                    Citizen citizen = new Citizen(name, age, id, birthDate);
                    hashset.Add(citizen);
                }
                else if (cmdArgs.Length == 3)
                {
                    string group = cmdArgs[2];
                    Rebel rebel = new Rebel(name, age, group);
                    hashset.Add(rebel);
                }

            }
            string names;
            while ((names = Console.ReadLine()) != "End")
            {
                var buyer = hashset.SingleOrDefault(b => b.Name == names);
                if (buyer != null)
                {
                buyer.BuyFood();

                }
                
            }
            int totalFood = 0;
            foreach (var buyer in hashset)
            {
                totalFood += buyer.Food;
            }
            Console.WriteLine(totalFood);
        }
            



    }
}
