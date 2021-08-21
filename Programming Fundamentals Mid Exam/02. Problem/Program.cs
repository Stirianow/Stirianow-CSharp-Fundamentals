using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> weapon = Console.ReadLine()
                .Split("|")
                .ToList();
            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] command = input.Split();

                switch (command[0])
                {
                    case "Add":

                        int currentIndexAt = int.Parse(command[2]);
                        if (currentIndexAt < weapon.Count)
                        {
                            weapon.Insert(currentIndexAt, command[1]);
                        }
                        break;
                    case "Remove":
                        int currentIndexToRemove = int.Parse(command[1]);
                        if (currentIndexToRemove < weapon.Count)
                        {
                            weapon.RemoveAt(currentIndexToRemove);
                        }
                        break;
                    case "Check":

                        if (command[1] == "Even")
                        {
                            List<string> listEven = new List<string>();
                            for (int i = 0; i < weapon.Count; i += 2)
                            {
                                listEven.Add(weapon[i]);
                            }
                            string currentWeapon = string.Join(" ", listEven);

                            Console.WriteLine(currentWeapon);
                        }
                        if (command[1] == "Odd")
                        {
                            List<string> listOdd = new List<string>();

                            for (int i = 1; i < weapon.Count; i += 2)
                            {
                                listOdd.Add(weapon[i]);
                            }
                            string currentWeapon = string.Join(" ", listOdd);

                            Console.WriteLine(currentWeapon);
                        }
                        break;
                }

                input = Console.ReadLine();
            }
            string craftedWeapon = string.Join("", weapon);
            Console.WriteLine($"You crafted {craftedWeapon}!");
        }
    }
}
