using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int volume = 255;
            int sum = 0;
            for (int i = 0; i < lines; i++)
            {
                int input = int.Parse(Console.ReadLine());
                sum += input;
                if (sum > volume)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= input;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
