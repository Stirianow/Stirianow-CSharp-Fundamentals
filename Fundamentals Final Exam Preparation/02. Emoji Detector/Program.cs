using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long coolThreshold = 1;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    int currentDigit = int.Parse(input[i].ToString());
                    coolThreshold *= currentDigit;
                }
            }
            Console.WriteLine($"Cool threshold: {coolThreshold}");
            string pattern = @"([*:])\1([A-Z][a-z]{2,})\1{2}";
            MatchCollection emojis = Regex.Matches(input, pattern);
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");
            if (emojis.Count<1)
            {
                return;
            }
            foreach (Match item in emojis)
            {
                string currentItem = item.Groups[2].Value;
                int sumofAscii = 0;
                foreach (char letter in currentItem)
                {
                    int ascii = (int)(letter);
                    sumofAscii += ascii;
                }
                if (sumofAscii > coolThreshold)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
