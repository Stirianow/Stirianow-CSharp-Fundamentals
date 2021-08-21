using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int startingN = n;
            int counter = 0;
            while (n >= m)
            {
                n -= m;
                if ((n == startingN/2) && y > 0)
                {
                    n /= y;
                }
                counter++;
            }
            Console.WriteLine(n);
            Console.WriteLine(counter);
        }
    }
}
