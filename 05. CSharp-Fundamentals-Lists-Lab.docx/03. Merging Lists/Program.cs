using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers1 = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            List<double> numbers2 = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            List<double> result = new List<double>();

            for (int i = 0; i < Math.Max(numbers1.Count, numbers2.Count); i++)
            {
                if (i < numbers1.Count)
                {
                    result.Add(numbers1[i]);
                }
                if (i < numbers2.Count)
                {
                    result.Add(numbers2[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
