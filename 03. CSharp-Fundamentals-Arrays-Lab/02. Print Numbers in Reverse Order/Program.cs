using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                array[i] = currentNum;
            }
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            //for (int i = 0; i < array.Length; i++)    
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"{array[(array.Length - 1) - i]} ");
            //}
        }
    }
}
