using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string vallidation = @"^%(?<name>[A-Z][a-z]+)%[^|$%.0-9]*?<(?<product>\w+)>[^|$%.0-9]*?\|(?<count>\d+)\|[^|$%.0-9]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            decimal totalIncome = 0;

            while (input != "end of shift")
            {
                Match match = Regex.Match(input, vallidation);
                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }
                string name = match.Groups["name"].Value;
                string product = match.Groups["product"].Value;
                int count = int.Parse(match.Groups["count"].Value);
                decimal price = decimal.Parse(match.Groups["price"].Value);
                decimal totalPrice = count * price;
                totalIncome += totalPrice;

                Console.WriteLine($"{name}: {product} - {totalPrice:f2}");

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
