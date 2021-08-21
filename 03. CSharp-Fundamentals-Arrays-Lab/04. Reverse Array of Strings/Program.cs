using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 1, 2, 3, 4, 5 };
            //string joined = string.Join(" ", array);
            //Console.WriteLine(joined);
            //string[] strings = Console.ReadLine().Split().Reverse().ToArray();
            //Console.WriteLine(string.Join(" ", strings));
            var items = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < items.Length/2; i++)
            {
                var oldValue = items[i];
                items[i] = items[items.Length - 1 - i];
                items[items.Length - 1 - i] = oldValue;
            }
            Console.WriteLine(string.Join(" ", items));
        }
    }
}
