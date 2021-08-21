using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int sum = SumOfTwo(num1, num2);
            int result = SubtractOfTwo(sum, num3);
            Console.WriteLine(result);
        }

        private static int SubtractOfTwo(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        static int SumOfTwo(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
    }
}
