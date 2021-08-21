using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"@[#]+[A-Z][a-zA-Z0-9]{4,}[a-zA-Z0-9]*[A-Z]@";
            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();
                Match validBarcode = Regex.Match(barcode, pattern);
                if (!validBarcode.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }
                string currentbarcode = validBarcode.Value;
                StringBuilder group = new StringBuilder();
                bool haveDigits = false;
                foreach (var symbol in currentbarcode)
                {
                    if (char.IsDigit(symbol))
                    {
                        group.Append(symbol);
                        haveDigits = true;
                    }
                }
                if (!haveDigits)
                {
                    Console.WriteLine($"Product group: 00");
                }
                else
                {
                    Console.WriteLine($"Product group: {group}");
                }

            }
        }
    }
}
