using System;

namespace _01._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputUsername = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Registration")
            {
                string[] input = command.Split();

                if (input[0] == "Letters")
                {
                    if (input[1] == "Lower")
                    {
                        inputUsername = inputUsername.ToLower();
                    }
                    else if (input[1] == "Upper")
                    {
                        inputUsername = inputUsername.ToUpper();
                    }
                    Console.WriteLine(inputUsername);
                }
                if (input[0] == "Reverse")
                {
                    int startIndex = int.Parse(input[1]);
                    int endIndex = int.Parse(input[2]);
                    string reversed = string.Empty;
                    for (int i = endIndex; i >= startIndex; i--)
                    {
                        reversed += inputUsername[i];
                    }
                    Console.WriteLine(reversed);
                }
                if (input[0] == "Substring")
                {
                    string substring = input[1];
                    if (inputUsername.Contains(substring))
                    {
                        int startIndex = inputUsername.IndexOf(substring);
                        inputUsername =  inputUsername.Remove(startIndex, substring.Length);
                        Console.WriteLine(inputUsername);
                    }
                    else if (!inputUsername.Contains(substring))
                    {
                        Console.WriteLine($"The username {inputUsername} doesn't contain {substring}.");
                    }
                }
                if (input[0] == "Replace")
                {
                    string toReplace = input[1];
                    inputUsername = inputUsername.Replace(toReplace[0],'-');
                    Console.WriteLine(inputUsername);
                }
                if (input[0] == "IsValid")
                {
                    string container = input[1];
                    if (inputUsername.Contains(container[0]))
                    {
                        Console.WriteLine("Valid username.");
                    }
                    else if (!inputUsername.Contains(container[0]))
                    {
                        Console.WriteLine($"{container[0]} must be contained in your username.");
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
