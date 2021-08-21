using System;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers1 = new int[n];
            int[] numbers2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (i % 2 == 0)
                {
                    numbers1[i] = int.Parse(input[0]);
                    numbers2[i] = int.Parse(input[1]);
                }
                else
                {
                    numbers2[i] = int.Parse(input[0]);
                    numbers1[i] = int.Parse(input[1]);
                }
            }
            Console.WriteLine(string.Join(" ", numbers1));
            Console.WriteLine(string.Join(" ", numbers2));

        }
    }
}
