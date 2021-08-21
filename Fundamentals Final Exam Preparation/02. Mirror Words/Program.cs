using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); ;
            string pattern = @"([@#])([a-zA-Z]{3,})\1{2}([a-zA-Z]{3,})\1";
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match item in matches)
            {
                string firstWord = item.Groups[2].ToString();
                string secondWord = item.Groups[3].ToString();
                string reverseWord = string.Empty;
                for (int i = secondWord.Length - 1; i >= 0; i--)
                {
                    reverseWord += secondWord[i];
                }
                if (firstWord == reverseWord)
                {
                    pairs.Add(firstWord, secondWord);
                }

            }
            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            if (pairs.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                List<string> mirrorWords = new List<string>();
                foreach (var pair in pairs)
                {
                    mirrorWords.Add($"{pair.Key} <=> {pair.Value}");
                }
                Console.WriteLine(string.Join(", ", mirrorWords));
            }
        }
    }
}
