using System;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] neighbourhood = Console.ReadLine().Split("@");

            int[] intNeighbourhood = new int[neighbourhood.Length];

            for (int i = 0; i < neighbourhood.Length; i++)
            {
                intNeighbourhood[i] = int.Parse(neighbourhood[i]);
            }

            string input = Console.ReadLine();

            int possition = 0;
            while (input != "Love!")
            {
                string[] command = input.Split();
                int jumpLenght = int.Parse(command[1]);
                if (jumpLenght < neighbourhood.Length - possition)
                {
                    possition += jumpLenght;
                }
                else
                {
                    possition = 0;
                }
                if (intNeighbourhood[possition] == 0)
                {
                    Console.WriteLine($"Place {possition} already had Valentine's day.");
                    input = Console.ReadLine();
                    continue;
                }

                intNeighbourhood[possition] -= 2;

                if (intNeighbourhood[possition] == 0)
                {
                    Console.WriteLine($"Place {possition} has Valentine's day.");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {possition}.");

            int counter = 0;

            for (int i = 0; i < intNeighbourhood.Length; i++)
            {
                if (intNeighbourhood[i] != 0)
                {
                   counter++;
                }
            }
            if (counter > 0)
            {
                Console.WriteLine($"Cupid has failed {counter} places.");
            }
            else if (counter == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
        }
    }
}
