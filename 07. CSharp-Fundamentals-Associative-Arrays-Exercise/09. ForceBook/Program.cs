using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var membersList = new Dictionary<string, List<string>>();

            while (input != "Lumpawaroo")
            {

                if (input.Contains(" | "))
                {
                    string[] currentInput = input.Split(" | ");
                    string side = currentInput[0];
                    string member = currentInput[1];
                    if (!membersList.ContainsKey(side))
                    {
                        membersList.Add(side, new List<string>());
                    }
                    if (!membersList[side].Contains(member))
                    {
                        membersList[side].Add(member);
                    }
                   
                }
                else
                {
                    string[] currentInput = input.Split(" -> ");
                    string member = currentInput[0];
                    string side = currentInput[1];
                    foreach (var item in membersList)
                    {
                        if (item.Key.Contains(member))
                        {
                            item.Value.Remove(member);
                        }
                    }
                    if (!membersList.ContainsKey(side))
                    {
                        membersList.Add(side, new List<string>());
                    }
                    membersList[side].Add(member);
                    Console.WriteLine($"{member} joins the {side} side!");
                }
                input = Console.ReadLine();
            }
            foreach (var item in membersList
                .Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(y => y.Key))
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");

                foreach (var user in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }

        }
    }
}
