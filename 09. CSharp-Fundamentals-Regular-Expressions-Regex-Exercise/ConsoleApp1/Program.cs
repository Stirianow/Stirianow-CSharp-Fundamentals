using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regexForDemons = @"[^\s,]+";
            string regexForPower = @"[^0-9.\/*+-]";
            string regexForDamage = @"(?:\+|-)?[0-9]+(?:\.[0-9]+)?";
            MatchCollection demons = Regex.Matches(input, regexForDemons);
            Dictionary<string, int[]> currentDeamon = new Dictionary<string, int[]>();
            foreach (Match demon in demons)
            {
                MatchCollection power = Regex.Matches(demon.Value, regexForPower);
                MatchCollection damage = Regex.Matches(demon.Value, regexForDamage);
                int sumForPower = 0;
                int sumForDamage = 0;
                foreach (Match a in power)
                {
                    string b = a.Value;
                    int ASCII = (int)(b[0]);
                    sumForPower += ASCII;
                }
                foreach (Match d in damage)
                {
                    string c = d.Value;
                    int val = int.Parse(c);
                    sumForDamage += val;
                }
                currentDeamon.Add(demon.Value, new int[2]);
                currentDeamon[demon.Value][0] = sumForPower;
                currentDeamon[demon.Value][1] = sumForDamage;
            }
            foreach (var item in currentDeamon)
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]} health, {item.Value[1]} damage");
            }
        }

    }
}
