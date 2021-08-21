using System;
using System.Text;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawKey = Console.ReadLine();
            string[] command = Console.ReadLine().Split(">>>");
            StringBuilder sb = new StringBuilder(rawKey);
            while (command[0] != "Generate")
            {
                if (command[0] == "Contains")
                {
                    string key = sb.ToString();
                    if (key.Contains(command[1]))
                    {
                        Console.WriteLine($"{sb} contains {command[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                if (command[0] == "Flip")
                {
                    for (int i = int.Parse(command[2]); i < int.Parse(command[3]); i++)
                    {
                        if (command[1] == "Upper")
                        {
                            sb[i] = char.ToUpper(sb[i]);
                        }
                        else if (command[1] == "Lower")
                        {
                            sb[i] = char.ToLower(sb[i]);
                        }
                    }
                    Console.WriteLine(sb);
                }
                if (command[0] == "Slice")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    int length = endIndex - startIndex;
                    sb.Remove(startIndex, length);
                    Console.WriteLine(sb);
                }

                command = Console.ReadLine().Split(">>>");
            }
            Console.WriteLine($"Your activation key is: {sb}");
        }
    }
}
