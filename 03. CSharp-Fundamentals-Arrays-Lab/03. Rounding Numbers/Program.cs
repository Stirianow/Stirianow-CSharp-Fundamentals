using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] splitted = Console.ReadLine().Split();
            //int[] numbers = new int[splitted.Length];
            //for (int i = 0; i < splitted.Length; i++)
            //{
            //    numbers[i] = int.Parse(splitted[i]);
            //}
            //for (int i = 0; i < splitted.Length; i++)
            //{
            //    Console.WriteLine($"array[{i}] = {splitted[i]}");
            //}

            //double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();



            string[] splitted = Console.ReadLine().Split();
            double[] numbers = new double[splitted.Length];
            for (int i = 0; i < splitted.Length; i++)
            {
                numbers[i] = double.Parse(splitted[i]);
            }
            for (int i = 0; i < splitted.Length; i++)
            {
                if (numbers [i] == 0)
                {
                    numbers[i] = 0;
                }
                //int roundedNum = (int) Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                //Console.WriteLine($"{numbers[i]} => {roundedNum}");
                Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
