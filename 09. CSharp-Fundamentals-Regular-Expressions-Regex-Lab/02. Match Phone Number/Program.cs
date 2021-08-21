using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+359(-|| )2\1[0-9]{3}\1[0-9]{4}\b";
            string input = Console.ReadLine();
            MatchCollection matched = Regex.Matches(input, regex);
            var matchList = matched
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(String.Join(", ", matchList));
        }
    }
}
