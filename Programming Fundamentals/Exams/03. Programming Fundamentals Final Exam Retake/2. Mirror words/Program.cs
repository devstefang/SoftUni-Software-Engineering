using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _2._Mirror_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([#@])([A-z]{3,})\1\1([A-z]{3,})\1";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            Match matches = regex.Match(input);
            StringBuilder sb = new StringBuilder();
            int count = 0;
            int mirrorWordCount = 0;
            List<string> mirrorWords = new List<string>();
            foreach (Match match in regex.Matches(input))
            {


                count++;
                string firstWord = match.Groups[2].Value;
                string secondWord = match.Groups[3].Value;
                string temp = string.Empty;
                for (int i = secondWord.Length - 1; i >= 0; i--)
                {
                    temp += secondWord[i];
                }
                if (temp == firstWord)
                {
                    mirrorWordCount++;
                    sb.Append($"{ firstWord} <=> {secondWord}, ");
                    mirrorWords.Add($"{firstWord} <=> { secondWord}");
                }

            }
            if (count > 0)
            {
                Console.WriteLine($"{count} word pairs found!");
            }
            else if ( count == 0) 
            {
                Console.WriteLine("No word pairs found!");
            }
            if (mirrorWordCount == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            if (mirrorWordCount > 0)
            {
                Console.WriteLine("The mirror words are: ");
                Console.WriteLine(string.Join(", ",mirrorWords));
            }



        }
    }
}
