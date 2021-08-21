using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> word = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    continue;
                }
                if (!word.ContainsKey(input[i]))
                {
                    word.Add(input[i], 0);
                }
                word[input[i]]++;
            }
            foreach (var item in word)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
