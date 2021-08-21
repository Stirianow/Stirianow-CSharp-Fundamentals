using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                IsItTop(i);
                if (IsItTop(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsItTop(int num)
        {
            bool isDivisableBy8 = false;
            bool holdsOddDigits = false;
            int sum = 0;
            int num1 = num;
            while (num > 0)
            {
                int currentResult = num % 10;
                sum += currentResult;
                num /= 10;
            }
            if (sum % 8 == 0)
            {
                isDivisableBy8 = true;
            }
            while (num1 > 0)
            {
                int currentNum = num1 % 10;
                if (currentNum % 2 != 0)
                {
                    holdsOddDigits = true;
                    break;
                }
                num1 /= 10;
            }
            if (holdsOddDigits == true && isDivisableBy8 == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
