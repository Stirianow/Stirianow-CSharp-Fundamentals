using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<int> result = new List<int>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                int[] numbers = input[i].
                    Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                foreach (var VARIABLE in numbers)
                {
                    result.Add(VARIABLE) ;
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
