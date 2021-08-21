using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
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
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                int element = int.Parse(commandArgs[1]);

                switch (action)
                {
                    case "Add":
                        numbers.Add(element);
                        break;
                    case "Remove":
                        numbers.Remove(element);
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(element);
                        break;
                    case "Insert":
                        int index = int.Parse(commandArgs[2]);
                        numbers.Insert(index, element);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers)); 
        }
    }
}
