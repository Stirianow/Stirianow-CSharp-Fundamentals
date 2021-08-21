using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> wordsInDict = new Dictionary<string, List<string>>();

            for (int i = 0; i < count; i++)
            {
                string keyWord = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (wordsInDict.ContainsKey(keyWord))
                {
                    wordsInDict[keyWord].Add(synonym);
                }
                else
                {
                    wordsInDict.Add(keyWord, new List<string>());
                    wordsInDict[keyWord].Add(synonym);
                }
            }
            foreach (var item in wordsInDict)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
