using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            switch (action)
            {
                case "add":
                    Add(x, y);
                    break;
                case "subtract":
                    Subtract(x, y);
                    break;
                case "multiply":
                    Multiply(x, y);
                    break;
                case "divide":
                    Divide(x, y);
                    break;
            }
        }
        static void Multiply(int x, int y) 
        {
            Console.WriteLine(x*y);
        }
        static void Subtract(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void Divide(int x, int y)
        {
            Console.WriteLine(x / y);
        }
    }
}
