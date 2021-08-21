using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            while (num % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                num = int.Parse(Console.ReadLine());
            }
            int numAbs = Math.Abs(num);
            Console.WriteLine($"The number is: {numAbs}");
        }
    }
}
