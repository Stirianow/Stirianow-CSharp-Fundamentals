using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> deck1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> deck2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (deck1.Count != 0 & deck2.Count != 0)
            {
                if (deck1[0] > deck2[0])
                {
                    int winningCard = deck1[0];
                    int lastCard = deck2[0];
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                    deck1.Add(winningCard);
                    deck1.Add(lastCard);
                }
                else if (deck2[0] > deck1[0])
                {
                    int winningCard = deck2[0];
                    int lastCard = deck1[0];
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                    deck2.Add(winningCard);
                    deck2.Add(lastCard);
                }
                else
                {
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                }
            }
            int sum = 0;
            if (deck1.Count == 0)
            {
                for (int i = 0; i < deck2.Count; i++)
                {
                    sum += deck2[i];
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
            else if (deck2.Count == 0)
            {
                for (int i = 0; i < deck1.Count; i++)
                {
                    sum += deck1[i];
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
        }
    }
}
