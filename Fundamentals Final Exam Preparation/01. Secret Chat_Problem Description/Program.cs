using System;
using System.Text;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder concealedMessage = new StringBuilder(Console.ReadLine());
            string message = Console.ReadLine();
            string[] command = Console.ReadLine().Split(":|:");
            while (command[0] != "Reveal")
            {
                if (command[0] == "InsertSpace")
                {
                    int index = int.Parse(command[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                if (command[0] == "Reverse")
                {
                    string substring = command[1];
                    string invertedSubstring = string.Empty;
                    for (int i = substring.Length - 1; i >= 0; i--)
                    {
                        invertedSubstring += substring[i];
                    }
                    if (message.Contains(substring))
                    {
                        int startIndex = message.IndexOf(substring);
                        message = message.Remove(startIndex, substring.Length);
                        message += invertedSubstring;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        command = Console.ReadLine().Split(":|:");
                        continue;
                    }
                    Console.WriteLine(message);
                }
                if (command[0] == "ChangeAll")
                {
                    string substring = command[1];
                    string replacement = command[2];
                    message = message.Replace(substring, replacement);
                    Console.WriteLine(message);
                }
                command = Console.ReadLine().Split(":|:");
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
