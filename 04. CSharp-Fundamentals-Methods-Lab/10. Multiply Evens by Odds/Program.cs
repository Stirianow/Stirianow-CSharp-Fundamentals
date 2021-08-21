using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int inputAbs = Math.Abs(input);
            int sumOfEvens = GetSumOfEvenDigits(inputAbs);
            int sumOfOdds = GetSumOfOddDigits(inputAbs);
            int result = GetMultipleOfEvenAndOdds(sumOfEvens, sumOfOdds);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int evens, int odds)
        {
            return evens * odds;
        }

        static int GetSumOfOddDigits(int num)
        {
            int sumOfOdd = 0;
            while (num > 0)
            {
                int currentNum = num % 10;
                if (currentNum % 2 != 0)
                {
                    sumOfOdd += currentNum;
                }
                num /= 10;
            }
            return sumOfOdd;
        }

        static int GetSumOfEvenDigits(int num)
        {
            int sumOfEven = 0;
            while (num > 0)
            {
                int currentNum = num % 10;
                if (currentNum % 2 == 0)
                {
                    sumOfEven += currentNum;
                }
                num /= 10;
            }
            return sumOfEven;
        }
    }
}
