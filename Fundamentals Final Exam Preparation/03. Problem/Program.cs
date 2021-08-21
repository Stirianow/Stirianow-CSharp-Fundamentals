using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLineInput = Console.ReadLine();
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            string[] words = firstLineInput.Split(" | ");
            foreach (var word in words)
            {
                string[] wordAndDefinition = word.Split(": ");
                string key = wordAndDefinition[0];
                string value = wordAndDefinition[1];
                if (dictionary.ContainsKey(key))
                {
                    dictionary[key].Add(value);
                }
                else
                {
                    dictionary.Add(key, new List<string>());
                    dictionary[key].Add(value);
                }
            }
            string[] testWords = Console.ReadLine().Split(" | ");
            string command = Console.ReadLine();
            if (command == "Hand Over")
            {
                List<string> sortedWords = new List<string>();
                foreach (var word in dictionary)
                {
                    sortedWords.Add(word.Key);
                }
                sortedWords.Sort();
                Console.WriteLine(string.Join(" ",sortedWords));
            }
            else if (command == "Test")
            {
                foreach (var testWord in testWords)
                {
                    if (dictionary.ContainsKey(testWord))
                    {
                        Console.WriteLine($"{testWord}:");
                        dictionary[testWord] = dictionary[testWord].OrderByDescending(x => x.Length).ToList();
                        foreach (var def in dictionary[testWord])
                        {
                            Console.WriteLine($" -{def}");
                        }
                    }
                }
            }
        }
    }
}
