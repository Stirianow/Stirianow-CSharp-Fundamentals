using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dict = new Dictionary<string, int>();
            int counter = 0;
            string previousInput = string.Empty;
            while (input != "stop")
            {
                counter++;
                if (counter % 2 != 0)
                {
                    if (!dict.ContainsKey(input))
                    {
                        dict.Add(input, 0);
                    }
                    previousInput = input;
                    input = Console.ReadLine();
                    continue;
                }
                else if (counter % 2 == 0)
                {
                    if (!dict.ContainsKey(previousInput))
                    {
                        dict.Add(previousInput, 0);
                    }
                    int currentInput = int.Parse(input);
                    dict[previousInput] += currentInput;
                }

                input = Console.ReadLine();
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
