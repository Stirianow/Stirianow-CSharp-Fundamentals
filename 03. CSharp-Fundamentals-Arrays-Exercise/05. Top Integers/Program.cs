using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            for (int i = input.Count - 1; i > 0; i--)
            {
                if (input[i] >= input[i-1])
                {
                    input.RemoveAt(i - 1);
                }
            }
            Console.WriteLine(string.Join(" ", input));
             //for (int i = 0; i < array.Length; i++)
             //{
             //    bool isBigger = true;
             //    for (int j = i; j < array.Length; j++)
             //    {
             //        if (array[i] < array[j])
             //        {
             //            isBigger = false;
             //            break;
             //        }
             //    }
             //    if (isBigger)
             //    {
             //        Console.Write($"{array[i]} ");
             //    }
             //}
             //Console.WriteLine();
        }
    }
}
