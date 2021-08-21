using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = string.Empty;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                pass += username[i];
            }
            string inputPass = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                if (pass == inputPass)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                    inputPass = Console.ReadLine();
                }
            }
            if (pass != inputPass)
            {
            Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}
