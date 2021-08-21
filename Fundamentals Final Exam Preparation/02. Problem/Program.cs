using System;
using System.Text.RegularExpressions;

namespace _02._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            string pattern = @"([U][$])([A-Z][a-z]{2,})\1([P][@][$])([a-zA-Z]{5,}[0-9]+)\3";
            int counter = 0;

            for (int i = 0; i < inputCount; i++)
            {
                string input = Console.ReadLine();
                Match currentInput = Regex.Match(input, pattern);
                if (currentInput.Success)
                {
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {currentInput.Groups[2]}, Password: {currentInput.Groups[4]}");
                    counter++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }
            Console.WriteLine($"Successful registrations: {counter}");
        }
    }
}
