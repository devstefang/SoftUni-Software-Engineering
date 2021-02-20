using System;

namespace _01._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pensPacket = 5.8;
            const double markersPacket = 7.2;
            const double detergentPerLitre = 1.2;
            // Input 
            
              int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            double detergent = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            double supplySum = pens * pensPacket + markers * markersPacket + detergent * detergentPerLitre;
            double priceWithDiscount = supplySum - (supplySum * discount / 100);
            Console.WriteLine($"{priceWithDiscount:f3}");




        }
    }
}
