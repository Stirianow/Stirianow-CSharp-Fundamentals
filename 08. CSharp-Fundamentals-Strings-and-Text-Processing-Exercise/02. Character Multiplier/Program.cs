using System;
using System.Collections.Generic;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string first = input[0];
            string second = input[1];
            var firstList = new List<int>();
            var secondList = new List<int>();
            foreach (var symbol in first)
            {
                int charCode = (int)symbol;
                firstList.Add(charCode);
            }
            foreach (var symbol in second)
            {
                int charCode = (int)symbol;
                secondList.Add(charCode);
            }

            int sum = 0;
            if (first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    sum += firstList[i] * secondList[i];
                }
            }
            else if (first.Length < second.Length)
            {
                while (firstList.Count > 0)
                {
                    sum += firstList[0] * secondList[0];
                    firstList.RemoveAt(0);
                    secondList.RemoveAt(0);
                }
                int leftover = 0;
                for (int j = 0; j < secondList.Count; j++)
                {
                    leftover += secondList[j];
                }
                sum += leftover;
            }
            else if (second.Length < first.Length)
            {
                while (secondList.Count > 0)
                {
                    sum += firstList[0] * secondList[0];
                    firstList.Remove(0);
                    secondList.Remove(0);
                }
                int leftover = 0;
                for (int j = 0; j < firstList.Count; j++)
                {
                    leftover += firstList[j];
                }
                sum += leftover;
            }
            Console.WriteLine(sum);
        }
    }
}
