using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            long factA = FactorialResult(a);
            long factB = FactorialResult(b);

            double result = (double)factA / factB;

            Console.WriteLine($"{result:f2}");
        }

        

        private static long FactorialResult(int n)
        {
            long result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
