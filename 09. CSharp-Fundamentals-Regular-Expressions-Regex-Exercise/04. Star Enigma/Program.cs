using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string counterPattern = "[SsTtAaRr]";
            string decryptionPattern = @"@([A-Z][a-z]+)[^@,\-!:>]*:([0-9]+)[^@,\-!:>]*!([A|D])![^@,\-!:>]*->([0-9]+)";

            int n = int.Parse(Console.ReadLine());
            int countAttacked = 0;
            int countDestroyed = 0;
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int count = Regex.Matches(input, counterPattern).Count;
                StringBuilder sb = new StringBuilder();
                foreach (char item in input)
                {
                    sb.Append((char)(item - count));
                }
                string decrypted = sb.ToString();

                Match match = Regex.Match(decrypted, decryptionPattern);
                if (!match.Success)
                {
                    continue;
                }
                string planetName = match.Groups[1].Value;
                string attackType = match.Groups[3].Value;
                if (attackType == "A")
                {
                    countAttacked++;
                    attacked.Add(planetName);
                }
                else if (attackType == "D")
                {
                    countDestroyed++;
                    destroyed.Add(planetName);
                }
            }

            Console.WriteLine($"Attacked planets: {countAttacked}");
            foreach (var item in attacked.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {countDestroyed}");
            foreach (var item in destroyed.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}
