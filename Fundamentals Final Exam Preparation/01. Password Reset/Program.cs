using System;
using System.Text;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "Done")
            {
                if (command[0] == "TakeOdd")
                {
                    StringBuilder newPass = new StringBuilder();
                    for (int i = 1; i < pass.Length; i += 2)
                    {
                        newPass.Append(pass[i]);
                    }
                    Console.WriteLine(newPass);
                    pass = newPass.ToString();
                }
                if (command[0] == "Cut")
                {
                    pass = pass.Remove(int.Parse(command[1]), int.Parse(command[2]));
                    Console.WriteLine(pass);
                }
                if (command[0] == "Substitute")
                {
                    if (pass.Contains(command[1]))
                    {
                        pass = pass.Replace(command[1], command[2]);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                        command = Console.ReadLine().Split();
                        continue;
                    }
                    Console.WriteLine(pass);
                }

                command = Console.ReadLine().Split();
            }
            Console.WriteLine($"Your password is: {pass}");
        }
    }
}
