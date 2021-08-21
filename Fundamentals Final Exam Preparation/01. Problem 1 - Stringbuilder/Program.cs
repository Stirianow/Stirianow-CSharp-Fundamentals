using System;
using System.Text;

namespace _01._Problem_1___Stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder username = new StringBuilder(Console.ReadLine());
            string[] command = Console.ReadLine().Split();

            while (command[0] != "Registration")
            {
                if (command[0] == "Letters")
                {
                   
                }


                command = Console.ReadLine().Split();
            }

            
        }
    }
}
