using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isEqual = true;
            int sum = 0;
            int indexNum = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                sum += firstArray[i];
                if (firstArray[i] != secondArray[i])
                {
                    isEqual = false;
                    indexNum = i;
                    break;
                }
            }
            if (isEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {indexNum} index");
            }
        }
    }
}
