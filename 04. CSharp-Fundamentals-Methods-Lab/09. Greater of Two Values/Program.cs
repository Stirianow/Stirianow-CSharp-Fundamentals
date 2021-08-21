using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfValue = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();
            if (typeOfValue == "int")
            {
                int firstInt = int.Parse(firstValue);
                int secondInt = int.Parse(secondValue);
                int result = GetMax(firstInt, secondInt);
                Console.WriteLine(result);
            }
            else if (typeOfValue == "char")
            {
                char firstChar = char.Parse(firstValue);
                char secondChar = char.Parse(secondValue);
                char result = (char)GetMax(firstChar, secondChar);
                Console.WriteLine(result);
            }
            else if (typeOfValue == "string")
            {
                string result = GetMax(firstValue, secondValue);
                Console.WriteLine(result);
            }
        }

        private static string GetMax(string firstString, string secondString)
        {
            int result = firstString.CompareTo(secondString);
            if (result == 1 || result == 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }

        private static int GetMax(int x, int y)
        {
            if (x >= y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
    }
}
