using System;

namespace _04._CSharp_Fundamentals_Methods_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int result = SmallestNum(n1, n2, n3);
            Console.WriteLine(result);
        }

        static int SmallestNum(int n1, int n2, int n3)
        {
            int start = int.MaxValue;
            if (n1 < start)
            {
                start = n1;
            }
            if (n2 < start)
            {
                start = n2;
            }
            if (n3 < start)
            {
                start = n3;
            }
            return start;
        }
    }
}
