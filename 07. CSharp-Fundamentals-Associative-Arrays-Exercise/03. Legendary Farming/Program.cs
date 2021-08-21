using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new Dictionary<string, int>();
            items.Add("shards", 0);
            items.Add("fragments", 0);
            items.Add("motes", 0);
            var junk = new Dictionary<string, int>();
            bool isLegendary = false;
            while (true)
            {
                string[] input = Console.ReadLine().Split();

                for (int i = 0; i < input.Length; i += 2)
                {
                    int value = int.Parse(input[i]);
                    string element = input[i + 1].ToLower();

                    if (element == "shards" || element == "fragments" || element == "motes")
                    {
                        items[element] += value;
                        if (items[element] >= 250)
                        {
                            switch (element)
                            {
                                case "shards":
                                    Console.WriteLine("Shadowmourne obtained!");
                                    break;
                                case "fragments":
                                    Console.WriteLine("Valanyr obtained!");
                                    break;
                                case "motes":
                                    Console.WriteLine("Dragonwrath obtained!");
                                    break;
                            }
                            items[element] -= 250;
                            isLegendary = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(element))
                        {
                            junk.Add(element, 0);
                        }
                        junk[element] += value;
                    }
                }
                if (isLegendary)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            foreach (var item in items.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
