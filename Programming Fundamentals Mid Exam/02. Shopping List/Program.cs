using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine()
                .Split("!")
                .ToList();

            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                string[] command = input.Split();
                if (command[0] == "Urgent")
                {
                    if (!shoppingList.Contains(command[1]))
                    {
                        shoppingList.Insert(0, command[1]);
                    }
                }
                else if (command[0] == "Unnecessary")
                {
                    shoppingList.Remove(command[1]);
                }
                else if (command[0] == "Correct")
                {
                    int index = shoppingList.IndexOf(command[1]);
                    if (index >= 0)
                    {
                        shoppingList.Remove(command[1]);
                        shoppingList.Insert(index, command[2]);
                    }
                }
                else if (command[0] == "Rearrange")
                {
                    if (shoppingList.Contains(command[1]))
                    {
                        shoppingList.Remove(command[1]);
                        shoppingList.Add(command[1]);
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}
