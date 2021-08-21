using System;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var username in input)
            {
                if (username.Length < 3 || username.Length > 16)
                {
                    continue;
                }
                bool isValid = false;
                foreach (var symbol in username)
                {
                    if (!(char.IsDigit(symbol) ||
                        char.IsLetter(symbol) ||
                        symbol == '_' ||
                        symbol == '-'))
                    {
                        isValid = false;
                        break;
                    }
                    isValid = true;
                }
                if (isValid)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}
