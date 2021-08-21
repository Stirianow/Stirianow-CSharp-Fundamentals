using System;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sortedInput = input.OrderByDescending(n => n).ToArray();
            for (int i = 0; i < sortedInput.Length; i++)
            {
                if (i <= 2)
                {
                    Console.Write(sortedInput[i] + " ");
                }
            }
        }
    }
}
