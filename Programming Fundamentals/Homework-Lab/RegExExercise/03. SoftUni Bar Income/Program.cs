using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%([A-Z][a-z]+)%[^|$%.]*<(\w+)>[^|$%.]*\|(\d+)\|(\d+.?\d*)\$";
            string input = Console.ReadLine();
            var regex = new Regex(input);
            Match match = Regex.Match(input, pattern);
            double income = 0;
            double totalPrice = 0;
            while (input != "end of shift")
            {


                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    string product = match.Groups[2].Value;
                    int count = int.Parse(match.Groups[3].Value);
                    double price = double.Parse(match.Groups[4].Value);
                    totalPrice = count * price;
                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                    income += totalPrice;
                }
                input = Console.ReadLine();
                match = Regex.Match(input, pattern);
            }

            Console.WriteLine($"Total income: {income:f2}");
        }
    }
}
