using System;
using System.Linq;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            IsItAValidPassword(input);
        }

        private static void IsItAValidPassword(string input)
        {
            bool isLongEnough = input.Length >= 6 && input.Length <= 10;
            bool onlyLettersAndDigits = input.All(Char.IsLetterOrDigit);
            bool twoDigitsAtLeast = false;
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    counter++;
                }

            }
            if (counter > 1)
            {
                twoDigitsAtLeast = true;
            }

            if (!isLongEnough)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!onlyLettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!twoDigitsAtLeast)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isLongEnough && onlyLettersAndDigits && twoDigitsAtLeast)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
