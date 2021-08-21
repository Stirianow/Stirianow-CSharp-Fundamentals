using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
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
                switch (action)
                {
                    case "PrintEven":
                        List<int> evenList = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                evenList.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", evenList));
                        break;

                    case "PrintOdd":
                        List<int> oddList = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 1)
                            {
                                oddList.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", oddList));
                        break;

                    case "Contains":
                        int element = int.Parse(commandArgs[1]);
                        bool contains = false;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == element)
                            {
                                contains = true;
                                break;
                            }
                        }
                        if (contains)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }
                        Console.WriteLine(sum);
                        break;

                    case "Filter":
                        string condition = commandArgs[1];
                        int num = int.Parse(commandArgs[2]);
                        switch (condition)
                        {
                            case ">":
                                List<int> result = new List<int>();
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] > num)
                                    {
                                        result.Add(numbers[i]);
                                    }
                                }
                                Console.WriteLine(string.Join(" ", result));
                                break;
                            case ">=":
                                List<int> result1 = new List<int>();
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] >= num)
                                    {
                                        result1.Add(numbers[i]);
                                    }
                                }
                                Console.WriteLine(string.Join(" ", result1));
                                break;
                            case "<":
                                List<int> result2 = new List<int>();
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] < num)
                                    {
                                        result2.Add(numbers[i]);
                                    }
                                }
                                Console.WriteLine(string.Join(" ", result2));
                                break;
                            case "<=":
                                List<int> result3 = new List<int>();
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] <= num)
                                    {
                                        result3.Add(numbers[i]);
                                    }
                                }
                                Console.WriteLine(string.Join(" ", result3));
                                break;
                        }
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
