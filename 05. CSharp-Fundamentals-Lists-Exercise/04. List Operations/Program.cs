using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] action = command.Split();

                switch (action[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(action[1]);
                        input.Add(numberToAdd);
                        break;
                    case "Insert":
                        int indexToInsert = int.Parse(action[2]);
                        int numberToInsert = int.Parse(action[1]);
                        if (indexToInsert < 0 || indexToInsert >= input.Count)
                        {
                            Console.WriteLine("Invalid index");
                            command = Console.ReadLine();
                            continue;
                        }
                        input.Insert(indexToInsert, numberToInsert);
                        break;
                    case "Remove":
                        int indexToRemove = int.Parse(action[1]);
                        if (indexToRemove < 0 || indexToRemove >= input.Count)
                        {
                            Console.WriteLine("Invalid index");
                            command = Console.ReadLine();
                            continue;
                        }
                        input.RemoveAt(indexToRemove);
                        break;
                    case "Shift":
                        if (action[1] == "right")
                        {
                            int n = int.Parse(action[2]);

                            for (int j = 0; j < n; j++)
                            {
                                int lastNum = input[input.Count - 1];

                                for (int i = input.Count - 1; i >= 1; i--)
                                {
                                    input[i] = input[i - 1];
                                }
                                input[0] = lastNum;
                            }

                        }
                        else if (action[1] == "left")
                        {
                            int n = int.Parse(action[2]);

                            for (int j = 0; j < n; j++)
                            {
                                int firstNum = input[0];

                                for (int i = 0; i < input.Count - 1; i++)
                                {
                                    input[i] = input[i + 1];
                                }
                                input[input.Count - 1] = firstNum;
                            }
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
