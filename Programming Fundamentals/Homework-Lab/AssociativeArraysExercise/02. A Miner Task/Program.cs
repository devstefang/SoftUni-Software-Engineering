using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            Dictionary<string, int> dict = new Dictionary<string, int>();

            while (resource != "stop")
            {

                if (!dict.ContainsKey(resource))
                {
                    dict.Add(resource, quantity);
                    

                }
                else
                {
                    dict[resource] += quantity;
                }






                resource = Console.ReadLine();
               
                if (resource == "stop")
                {
                    break;
                }
                quantity = int.Parse(Console.ReadLine());
                
            }
            foreach (var values in dict)
            {
                Console.WriteLine($"{values.Key} –> {values.Value}");
            }



        }
    }
}
