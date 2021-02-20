using System;
using System.IO;

namespace CarManufacturer
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            Tire[] tire = new Tire[4]
            {
                new Tire(2008, 2),
                new Tire(2008, 2),
                new Tire(2008, 2),
                new Tire(2008, 2),
            };
            var engine = new Engine(600, 6300);
            var car = new Car("Lambo", "Urus", 2010, 250, 9, engine, tire);
            
            
        }
    }
}
