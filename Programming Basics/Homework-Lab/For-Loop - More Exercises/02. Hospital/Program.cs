using System;
using System.Security.Cryptography;

namespace _02._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input 
            int days = int.Parse(Console.ReadLine());
            int treatedPatients = 0;
            int untreatedPatients = 0;
            int doctors = 7;
            for (int i = 1; i <= days; i++)
            {
               

                if ( i % 3 == 0)
                {
                    if (untreatedPatients > treatedPatients)
                    {
                        doctors++;
                    }
                }
                int patients = int.Parse(Console.ReadLine());
                if (  doctors < patients)
                {
                    treatedPatients += doctors;
                    untreatedPatients += patients - doctors;
                }
                else 
                {
                    treatedPatients += patients;
                   
                    
                }
                
                
                

            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");

        }
    }
}
