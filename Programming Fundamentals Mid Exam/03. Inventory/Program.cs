using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(", ")
                .ToList();
            string[] command = Console.ReadLine().Split(" - ");

            while (command[0] != "Craft!")
            {
                switch (command[0])
                {
                    case "Collect":
                        if (!items.Contains(command[1]))
                        {
                            items.Add(command[1]);
                        }
                        break;
                    case "Drop":
                        items.Remove(command[1]);
                        break;
                    case "Combine Items":
                        string[] newItems = command[1].Split(":");
                        string newItem = newItems[1];
                        string oldItem = newItems[0];

                        int index = items.IndexOf(oldItem);
                        if (index >= 0)
                        {
                            items.Insert(index + 1, newItem);
                        }
                        break;
                    case "Renew":
                        if (items.Remove(command[1]))
                        {
                            items.Add(command[1]);
                        }
                        break;

                }


                command = Console.ReadLine().Split(" - ");
            }
            Console.WriteLine(string.Join(", ", items));
        }
    }
}
