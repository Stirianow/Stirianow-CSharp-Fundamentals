using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] action = command.Split();

                if (action[0] == "Delete")
                {
                    int target = int.Parse(action[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == target)
                        {
                            numbers.Remove(numbers[i]);
                        }
                    }
                }
                if (action[0] == "Insert")
                {
                    int element = int.Parse(action[1]);
                    int position = int.Parse(action[2]);

                    numbers.Insert(position, element);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
