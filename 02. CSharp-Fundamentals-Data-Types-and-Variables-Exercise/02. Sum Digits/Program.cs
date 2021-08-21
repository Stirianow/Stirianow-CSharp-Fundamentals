using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            //while (num > 0)
            //{
            //    int currentNum = num;
            //    currentNum %= 10;
            //    sum += currentNum;
            //    num /= 10;
            //}

            Console.WriteLine(sum);
        }
    }
}
