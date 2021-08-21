using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i; j < array.Length - 1; j++)
                {
                    if (array[i] + array[j + 1] == num)
                    {
                        Console.WriteLine($"{array[i]} {array[j + 1]}");
                    }
                }
            }
        }
    }
}
