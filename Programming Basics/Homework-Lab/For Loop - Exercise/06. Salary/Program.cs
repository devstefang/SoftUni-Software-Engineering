using System;

namespace _06._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	"Facebook"-> 150 лв.
            //•	"Instagram"-> 100 лв.
            //•	"Reddit"-> 50 лв.

            // Input
            const int facebook = 150;
            const int instagram = 100;
            const int reddit = 50;
            int openedBrowsers = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= openedBrowsers; i++)
            {
                if (salary == 0)
                {
                    Console.WriteLine("You have lost your salary.");
                        break;
                }
                string browsers = Console.ReadLine();
                if (browsers == "Facebook")
                {
                    salary = salary - facebook;
                }
                else if(browsers == "Instagram")
                {
                    salary = salary - instagram;
                }
                else if(browsers == "Reddit")
                {
                    salary = salary - reddit;
                }
                
               
                
            }

            if (salary > 0)
           

            {
                Console.WriteLine(salary);
            }

        }
    }
}
