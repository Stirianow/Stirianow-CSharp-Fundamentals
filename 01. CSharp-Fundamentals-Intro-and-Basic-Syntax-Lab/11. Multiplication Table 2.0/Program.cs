using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int theTimes = int.Parse(Console.ReadLine());
            for (int i = theTimes; i <= 10; i++)
            {
                int product = theInteger * i;
                Console.WriteLine($"{theInteger} X {i} = {product}");
            }
            if (theTimes > 10)
            {
                int timeOver10 = theTimes * theInteger;
                Console.WriteLine($"{theInteger} X {theTimes} = {timeOver10}");
            }
        }
    }
}
