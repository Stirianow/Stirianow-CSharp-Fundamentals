using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] studentsAge = new int[6];
            //studentsAge[3] = 20;
            //Console.WriteLine(studentsAge[3]);
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(days[num-1]);
            //int[] array = new int[10];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = i * 5;
            //    Console.WriteLine(array[i]);
            //}
            int day = int.Parse(Console.ReadLine());
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(days[day - 1]);
            }
        }
    }
}
