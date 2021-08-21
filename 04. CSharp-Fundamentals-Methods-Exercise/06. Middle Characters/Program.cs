using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddle(input);
        }

        private static void PrintMiddle(string input)
        {
            int middleChar = input.Length / 2;
            if (input.Length % 2 == 0)
            {
                Console.WriteLine($"{input[middleChar-1]}{input[middleChar]}");
            }
            else
            {
                Console.WriteLine($"{input[middleChar]}");
            }
        }
    }
}
