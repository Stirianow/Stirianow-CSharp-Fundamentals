using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxElements = 0;
            int currentEqual = 1;
            int element = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    currentEqual++;
                }
                else
                {
                    currentEqual = 1;
                }
                if (currentEqual > maxElements)
                {
                    maxElements = currentEqual;
                    element = array[i];
                }
            }
            for (int i = 0; i < maxElements; i++)
            {
                Console.Write(element + " ");
            }
        }
    }
}
