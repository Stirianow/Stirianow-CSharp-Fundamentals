using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> productList = Console.ReadLine()
                .Split("|")
                .ToList();
            string input = Console.ReadLine();

            while (input != "Shop!")
            {
                string[] command = input.Split("%");
                if (command[0] == "Important")
                {
                    if (productList.Contains(command[1]))
                    {
                        productList.Remove(command[1]);
                        productList.Insert(0, command[1]);
                    }
                    else
                    {
                        productList.Insert(0, command[1]);
                    }
                }
                if (command[0] == "Add")
                {
                    if (!productList.Contains(command[1]))
                    {
                        productList.Add(command[1]);
                    }
                    else
                    {
                        Console.WriteLine("The product is already in the list.");
                    }
                }
                if (command[0] == "Swap")
                {
                    if (!productList.Contains(command[1]))
                    {
                        Console.WriteLine($"Product {command[1]} missing!");
                        input = Console.ReadLine();
                        continue;
                    }
                    if (!productList.Contains(command[2]))
                    {
                        Console.WriteLine($"Product {command[2]} missing!");
                        input = Console.ReadLine();
                        continue;
                    }
                    int firstProductIndex = 0;
                    int secondProductIndex = 0;
                    for (int i = 0; i < productList.Count; i++)
                    {
                        if (productList[i] == command[1])
                        {
                            firstProductIndex = i;
                        }
                        else if (productList[i] == command[2])
                        {
                            secondProductIndex = i;
                        }
                    }
                    productList.Reverse(firstProductIndex, secondProductIndex);
                }
                if (command[0] == "Remove")
                {

                    if (productList.Contains(command[1]))
                    {
                        productList.Remove(command[1]);
                    }
                    else
                    {
                        Console.WriteLine($"Product {command[1]} isn't in the list.");
                    }
                }
                if (command[0] == "Reversed")
                {
                    productList.Reverse();
                }

                input = Console.ReadLine();
            }

            for (int j = 0; j < productList.Count; j++)
            {
                Console.WriteLine($"{j + 1}. {productList[j]}");
            }
        }
    }
}
