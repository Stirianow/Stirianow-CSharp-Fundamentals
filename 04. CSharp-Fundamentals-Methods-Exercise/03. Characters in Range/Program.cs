using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            PrintCharsBetween(start, end);

        }

        private static void PrintCharsBetween(char start, char end)
        {
            int startASCII = (int)Convert.ToChar(start);
            int endASCII = (int)Convert.ToChar(end);
            if (startASCII <= endASCII)
            {
                for (int i = startASCII + 1; i < endASCII; i++)
                {
                    Console.Write(Convert.ToChar(i) + " ");
                }
            }
            else
            {
                for (int i = endASCII + 1; i < startASCII; i++)
                {
                    Console.Write(Convert.ToChar(i) + " ");
                }
            }
        }
    }
}
