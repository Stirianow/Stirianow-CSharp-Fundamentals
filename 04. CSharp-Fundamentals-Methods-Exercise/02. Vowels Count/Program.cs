using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int vowelCounter = CountTheVowels(input);
            Console.WriteLine(vowelCounter);
        }

        static int CountTheVowels(string input)
        {
            int count = 0;
            string inputToLow = input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                if (inputToLow[i] == 'a' || inputToLow[i] == 'o' || inputToLow[i] == 'u' || inputToLow[i] == 'e'|| inputToLow[i] == 'i')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
