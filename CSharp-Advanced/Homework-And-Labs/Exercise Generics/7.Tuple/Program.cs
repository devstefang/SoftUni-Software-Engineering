using System;
using System.IO;

namespace _7.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string firstName = firstInput[0];
            string LastName = firstInput[1];
            string adress = firstInput[2];
            string town = firstInput[3];
            string combinedNames = $"{firstName} {LastName}";
            Tuple<string, string,string> firstTuple = new Tuple<string, string,string>(combinedNames, adress,town);
            string[] secondInput = Console.ReadLine().Split();
            string name = secondInput[0];
            int litersOfBeer = int.Parse(secondInput[1]);
            bool isDrunk = secondInput[2] == "drunk";
            Tuple<string, int,bool> secondTuple = new Tuple<string, int,bool>(name, litersOfBeer,isDrunk);
            string[] ThirdInput = Console.ReadLine().Split();
            string accountName = ThirdInput[0];
            double doubleValue = double.Parse(ThirdInput[1]);
            string bankName = ThirdInput[2];
            Tuple<string, double,string> thirdTuple = new Tuple<string, double,string>(accountName, doubleValue,bankName);
            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
