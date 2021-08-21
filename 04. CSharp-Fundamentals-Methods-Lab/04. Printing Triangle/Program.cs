using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            PrintTriangle(input);
        }

        static void PrintTriangle(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int i = 1; i <= row ; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            for (int row = n - 1; row >= 1; row--)
            {
                for (int i = 1; i <= row; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
