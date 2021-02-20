using System;
using System.Text.RegularExpressions;

namespace _2._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#+([A-Z]([A-Za-z0-9]{4,})[A-Z])@#+";
            int n = int.Parse(Console.ReadLine());
            string allBarcodes = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string compare = match.Value;
                    string temp = string.Empty;
                    for (int j = 0; j < compare.Length; j++)
                    {
                        if (char.IsDigit(compare[j]))
                        {

                            temp += compare[j];
                        }
                    }
                    if (temp == "")
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {temp}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }



        }
    }
}
