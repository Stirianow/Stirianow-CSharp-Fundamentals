using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                //string input = Console.ReadLine();
                //sum += input[0];
                char a = char.Parse(Console.ReadLine());
                sum += a;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
