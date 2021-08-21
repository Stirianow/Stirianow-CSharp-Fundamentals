using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = new List<string> { " " };

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] action = input.Split();

                if (action[2] == "going!")
                {
                    bool isInList = false;
                    for (int j = 0; j < guestList.Count; j++)
                    {
                        if (action[0] == guestList[j])
                        {
                            isInList = true;
                            Console.WriteLine($"{action[0]} is already in the list!");
                            break;
                        }
                    }
                    if (!isInList)
                    {
                        guestList.Add(action[0]);
                    }
                }
                if (action[2] == "not")
                {
                    bool isNotInList = true;
                    for (int j = 0; j < guestList.Count; j++)
                    {
                        if (action[0] == guestList[j])
                        {
                            isNotInList = false;
                            guestList.Remove(guestList[j]);
                            break;
                        }
                    }
                    if (isNotInList)
                    {
                        Console.WriteLine($"{action[0]} is not in the list!");
                    }
                }
            }
            guestList.Remove(" ");

            for (int k = 0; k < guestList.Count; k++)
            {
                Console.WriteLine(guestList[k]);
            }
        }
    }
}
