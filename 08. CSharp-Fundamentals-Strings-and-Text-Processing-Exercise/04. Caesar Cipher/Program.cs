using System;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = string.Empty;
            foreach (var item in input)
            {
                int newChar = (int)item + 3;
                char encrypted = (char)newChar;
                output += encrypted;
            }
            Console.WriteLine(output);
        }
    }
}
