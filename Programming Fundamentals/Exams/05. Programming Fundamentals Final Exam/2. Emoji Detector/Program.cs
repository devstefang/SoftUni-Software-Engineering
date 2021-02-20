using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string numPattern = @"\d";
            string pattern = @"([::**]{2})([A-Z][a-z]{2,})\1";
            string input = Console.ReadLine();
            Regex numReg = new Regex(numPattern);
            Regex emojiPattern = new Regex(pattern);
            int count = 0;
            long coolThreshhold = 1;
            numReg.Matches(input)
                .Select(m => m.Value)
                .Select(int.Parse)
                .ToList()
                .ForEach(x => coolThreshhold *= x);
            var matches = emojiPattern.Matches(input);
            int emojiCount = matches.Count;
            List<string> emojiMatches = new List<string>();
            foreach (Match match in matches)
            {
                long coolSum = match.Value
                    .Substring(2, match.Length - 4)
                    .ToCharArray()
                    .Sum(x=>(int)x);
                if (coolSum > coolThreshhold)
                {
                    emojiMatches.Add(match.ToString());


                }
                count++;
            }
            Console.WriteLine($"Cool threshold: {coolThreshhold}");
            Console.WriteLine($"{count} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join(Environment.NewLine,emojiMatches));

        }
    }
}
