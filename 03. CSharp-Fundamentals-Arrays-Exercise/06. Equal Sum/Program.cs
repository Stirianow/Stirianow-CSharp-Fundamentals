using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isFound = false;
            int leftSum = 0;
            int rightSum = 0;
            if (array.Length == 1)
            {
                Console.WriteLine(array[0]);
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (j > i)
                    {
                        rightSum += array[j];
                    }
                    else if (j == i)
                    {
                        continue;
                    }
                    else
                    {
                        leftSum += array[j];
                    }
                }
                if (rightSum == leftSum && array.Length > 2)
                {
                    Console.WriteLine(array[i]);
                    isFound = true;
                    break;
                }

            }
            if (rightSum != leftSum && isFound == false)
            {
                Console.WriteLine("no");
            }
            //int middleNum = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    int leftSum = 0;
            //    int rightSum = 0;
            //    int middle = i + 1;
            //    for (int j = 0; j <= i; j++)
            //    {
            //        leftSum += array[j];
            //    }
            //    for (int j = i+2; j < array.Length; j++)
            //    {
            //        rightSum += array[j];
            //    }
            //    if (array.Length == 1)
            //    {
            //        isFound = true;
            //        middleNum = 0;
            //    }
            //    if (leftSum == rightSum)
            //    {
            //        isFound = true;
            //        middleNum = middle;
            //    }

            //}
            //if (!isFound)
            //{
            //    Console.WriteLine("no");
            //}
            //else
            //{
            //    Console.WriteLine(middleNum);
            //}
        }
    }
}
