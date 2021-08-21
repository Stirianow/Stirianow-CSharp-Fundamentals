using System;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^>>([A-z]+)<<([0-9]+.*[0-9]*)!([0-9]+)";
            string input = Console.ReadLine();
            decimal totalPrice = 0;
            Console.WriteLine("Bought furniture:");
            while (input != "Purchase")
            {
                Match match = Regex.Match(input, pattern);
                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }
                string product = match.Groups[1].Value;
                decimal price = decimal.Parse(match.Groups[2].Value);
                int qty = int.Parse(match.Groups[3].Value);
                totalPrice += (price * qty);

                input = Console.ReadLine();
                Console.WriteLine(product);
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
