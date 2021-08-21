using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> passengers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int capacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] action = command.Split();

                if (action[0] == "Add")
                {
                    int newWagons = int.Parse(action[1]);
                    passengers.Add(newWagons);
                }
                else
                {
                    int newPassengers = int.Parse(action[0]);

                    for (int i = 0; i < passengers.Count; i++)
                    {
                        if (capacity - passengers[i] >= newPassengers)
                        {
                            passengers[i] += newPassengers;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", passengers));
        }
    }
}
