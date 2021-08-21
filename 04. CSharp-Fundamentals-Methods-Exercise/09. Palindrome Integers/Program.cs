using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                IsPalindrome(input);
                input = Console.ReadLine();
            }
        }

        private static void IsPalindrome(string input)
        {
            string reverseInput = string.Empty;
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverseInput += input[i];
                }
                int c = string.Compare(input, reverseInput);
                if (c == 0)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
        }
    }
}
