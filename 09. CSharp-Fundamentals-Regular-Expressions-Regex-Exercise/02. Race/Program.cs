using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternForName = @"[A-Za-z]";
            string patternForDistance = @"[0-9]";
            Dictionary<string, int> competitors = new Dictionary<string, int>();
            string[] racers = Console.ReadLine().Split(", ");

            foreach (var item in racers)
            {
                competitors.Add(item, 0);
            }
            string input = Console.ReadLine();

            while (input != "end of race")
            {
                var regexForName = Regex.Matches(input, patternForName);
                StringBuilder name = new StringBuilder();
                int currentDistance = 0;
                foreach (Match item in regexForName)
                {
                    name.Append(item);
                }
                var regexForDistance = Regex.Matches(input, patternForDistance);

                foreach (Match item in regexForDistance)
                {
                    currentDistance += int.Parse(item.Value);
                }
                string nameToString = name.ToString();
                if (!competitors.ContainsKey(nameToString))
                {
                    input = Console.ReadLine();
                    continue;
                }
                competitors[nameToString] += currentDistance;

                input = Console.ReadLine();
            }
            //competitors.OrderByDescending(x => x.Value);
            int counter = 1;
            foreach (var item in competitors.OrderByDescending(x => x.Value))
            {
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                    counter++;
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                    counter++;
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                    counter++;
                }
            }
            
        }
    }
}
